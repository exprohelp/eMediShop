SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DataBackup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DataBackup]
@dbname varchar(50),
@backupPath varchar(100)
AS
declare @dbnamepath varchar(100)
declare @dbbackupname varchar(100)

set @dbnamepath=ltrim(@backupPath)
set @dbbackupname=ltrim(@dbname)+''_Auto''
EXEC sp_addumpdevice ''disk'',@dbbackupname,@dbnamepath
backup database @dbname to @dbbackupname 
exec sp_dropdevice @dbbackupname
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pCorpNewMedicineIns]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[pCorpNewMedicineIns]
  @Corp_Id varchar(16),
  @Item_name varchar(50),
  @Qty int,
  @login_id varchar(10),
  @result varchar(50) output
  As
  if not exists(select * from CorpNewProduct where med_name=@Item_name)
   BEGIN
   Insert into CorpNewProduct(Corp_Id,med_Name,Qty,login_id) values(@Corp_Id,@Item_Name,@Qty,@login_id)
   set @result=''Success''
   END
  else
   BEGIN
   set @result=''Duplicate''
   END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsVendorApprInfo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pInsVendorApprInfo]
    @Vendor_Name nvarchar(50),
    @Tin_No nvarchar(50),
    @Contact_Person nvarchar(50),
    @Address1 nvarchar(50),
    @City nvarchar(20),
    @State nvarchar(20),
    @Phone nvarchar(20),
    @login_By nvarchar(50),
    @result varchar(50) output
AS
INSERT INTO [Vendor_Appr_Info] (Vendor_Name,Tin_No,Contact_Person,Address1,City, State, Phone,login_By)
VALUES (@Vendor_Name,@Tin_No,@Contact_Person,@Address1,@City,@State,@Phone,@login_By)
 set @result=''Successfully Inserted''
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pCorpIndentFeeding]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[pCorpIndentFeeding]
  @Corp_Id varchar(16),
  @Item_Id varchar(10),
  @IndDate Datetime,
  @Qty int,
  @login_id varchar(10),
  @result varchar(50) output
  As
   Insert into Daily_Indent_Info (Corp_Id,Item_Id,Ind_Date,Qty,login_id) values(@Corp_Id,@Item_Id,@IndDate,@Qty,@login_id)
   set @result=''Success''
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pCorpNewIndenReport]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--select  [192.192.192.19].emedicentral.dbo.item_masterfnitemlocation(''CP07540'') 
 Create procedure [dbo].[pCorpNewIndenReport] --''CORP0005'',''2010/12/22''
 @CorpId varchar(200),
 @Ind_date datetime 
as
select IndentInfo.item_id, Item_Name, Mfd_Name, shelf_no, Quantity, HoStocks,batch_no,
 ISNULL(isnull(MaxMrpInfo.npr,0)/isnull(MaxMrpInfo.pack_qty,1), 0) AS unpr,isnull(MaxMrpInfo.npr,0) npr,isnull(maxmrpinfo.pack_qty,0) pack_qty,
''MR-''+cast(MaxMrpInfo.mrp as varchar(10))+'', UM-''+cast(round((cast(isnull(MaxMrpInfo.mrp,0) as money)/cast(isnull(MaxMrpInfo.pack_qty,1) as money)),2) as varchar(10))+'', PQ-''+Cast(MaxMrpInfo.pack_qty as varchar(10)) MaxMrpInfo,
ISNULL(isnull(MaxMrpInfo.mrp,0)/isnull(MaxMrpInfo.pack_qty,1), 0) umrp, isnull(MaxMrpInfo.mrp,0) mrp from (
	SELECT     im.item_id, im.Item_Name, mfd.Mfd_Name, CurHoStock.shelf_no, SUM(ind.Qty) AS Quantity, CurHoStock.qty HoStocks
	FROM         dbo.Mfd_Master AS mfd INNER JOIN
	                      Item_Master AS im ON mfd.Mfd_id = im.Mfd_Id INNER JOIN
		                  dbo.Daily_Indent_Info AS ind ON im.item_id = ind.Item_Id LEFT OUTER JOIN
		                    CurHoStock ON ind.Item_Id = CurHoStock.Item_Id 
	WHERE     (@CorpId LIKE ''%'' + ind.Corp_Id + ''%'') AND (CONVERT(varchar(10), ind.Ind_Date, 111) = @Ind_date )
	GROUP BY im.item_id, im.Item_Name, mfd.Mfd_Name, CurHoStock.shelf_no,CurHoStock.qty
) IndentInfo left outer join MaxMrpInfo on IndentInfo.item_id=MaxMrpInfo.Item_id;
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pCreateLedgers]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[pCreateLedgers]
@unit_id varchar(10),
@ledger_name varchar(70),
@ledgerType varchar(40) --Salary: For Salary Account, Vendor: For Vendor Account
as
set nocount on;
if(@ledgertype=''Salary'')
begin
	set @ledger_name=ltrim(@ledger_name)+ ''(Salary A/c)''
	if not exists(select * from ledgermaster where unit_id=@unit_id and ld_name like @ledger_name)
	begin
		insert into ledgermaster(unit_id,code_value,code_category,type,ld_name,cr_name,cr_address,opening,closing,crdr)
		values (@unit_id,70401,704,''E'',@ledger_name,@ledger_name,''-'',0,0,''CR'')
	end
	select ld_code,ld_name from ledgermaster where unit_id=@unit_id and ld_name=@ledger_name;
end
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetDaybook]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create PROCEDURE [dbo].[GetDaybook]
@booksfrom datetime,
@booksto datetime
 AS
set nocount on

declare @ld_code int
declare @vchdate datetime
declare @ldg_credit int
declare @ld_name varchar(100)
declare @dr_amount money
declare @cr_amount money
declare @vchtype varchar(10)
declare @voucherno varchar(12)


create table #t (cr_date datetime ,ld_code int ,Particular varchar(100),vch_type varchar(10),voucher_no varchar(12),dr_amount money,cr_amount money)

 

declare c1 cursor for select vch_date,ldg_credit,vch_type,voucher_no,db_amount,cr_amount  from ledgerbooks 
where  vch_date between @booksfrom and @booksto 
open c1 
fetch next from c1 into  @vchdate,@ldg_credit,@vchtype,@voucherno,@dr_amount,@cr_amount
while @@fetch_status=0
begin

select @ld_name=ld_name from LedgerMaster where ld_code=@ldg_credit

insert into #t (cr_date,ld_code,particular,vch_type,voucher_no,dr_amount,cr_amount) 
values (@vchdate,@ldg_credit,@ld_name,@vchtype,@voucherno,@dr_amount,@cr_amount)

fetch next from c1 into  @vchdate,@ldg_credit,@vchtype,@voucherno,@dr_amount,@cr_amount
end
close c1
deallocate c1
select * from #t order by cr_date
' 
END
GO
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteVoucherMaster]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DeleteVoucherMaster]

 AS
declare @vNo varchar(20)
declare @vtype varchar(10)
declare c1 cursor for select voucher_no,vch_type from vouchermaster where vch_date between ''2006-05-01'' and ''2007-10-01''
open c1
fetch next from c1 into @vno,@vtype
while @@fetch_status=0
begin
delete from vouchermaster where voucher_no=@vNo and vch_type=@vtype
fetch next from c1 into @vno,@vtype
end
close c1
deallocate c1
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pVoucherPosting]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--Vijay Singh
--Voucher Posting
CREATE procedure [dbo].[pVoucherPosting] 
@unit_id varchar(10),
@voucher_date datetime,
@voucher_type varchar(10),
@cr_Ledger varchar(100),
@dr_ledger varchar(100),
@amount money,
@narration varchar(100),
@login_id varchar(10),
@voucher_no varchar(15),
@result varchar(100) output
as
declare @dr_ledg_code varchar(10),@cr_ledg_code varchar(10),@CreditLedgerOk Char(1),@DebitLedgerOk Char(1)
	set @CreditLedgerOk=''N''
	set @DebitLedgerOk=''N''

	select @dr_ledg_code=ledg_debit,@cr_ledg_code=ledg_credit from vouchermaster where voucher_no=@voucher_no and Unit_id=@unit_id
    select @result=''Inserted Successfully.''
	--Debit Ledger Checking
	if exists (select * from ledgermaster where ld_name=@dr_ledger)
	begin
  		select @dr_ledg_code=ld_code from ledgermaster where ld_name=@dr_ledger  
		set @DebitLedgerOk=''Y''
	end	
	--Credit Ledger Checking
	if exists (select * from ledgermaster where ld_name=@cr_ledger)
	begin
  		select @cr_ledg_code=ld_code from ledgermaster where ld_name=@cr_ledger  
		set @CreditLedgerOk=''Y''
	end	

	
	if  @CreditLedgerOk =''Y'' and @DebitLedgerOk =''Y''
	begin 
		if not exists (select * from vouchermaster where  voucher_no=@voucher_no )
		begin
			insert into vouchermaster (voucher_no,vch_type,vch_date,ledg_debit,ledg_credit,amount,narration,genfrom,unit_id,trf_flag,login_id)
			values(@voucher_no,@voucher_type,@voucher_date,@dr_ledg_code,@cr_ledg_code,@amount,@narration,''Auto'',@unit_id,''N'',@login_id)
		end
	end
	else
	begin
		if @CreditLedgerOk=''N''
				select @result=''Credit Ledger Name not Exists.''
		if @DebitLedgerOk=''N''
				select @result=''Debit Ledger Name not Exists.''
		if @DebitLedgerOk=''N'' and @CreditLedgerOk=''N''
				select @result=''Both Ledger Name not Exists.''
	end

if @@error!=0
	select @result=''Error In Posting''
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pIndentPrintingProcess]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create procedure [dbo].[pIndentPrintingProcess] --''006018661/09-10''
@sale_inv_no varchar(16)
as

select isnull(cast(si.auto_id as varchar(10)),''X'') id,pt_name,x.sale_inv_no,x.item_id,dbo.fnGetMfdName(x.item_id) mfd_name,x.item_name,indent_qty,
convert(decimal(10,2),(isnull(si.pack_mrp,0))) mrp ,isnull(si.pack_qty,0) pack_qty,si.batch_no, convert(decimal(10,2),(isnull((si.pack_mrp/si.pack_qty)*indent_qty,0))) as amount from 
(select sale_inv_no,item_id,dbo.fnitemname(item_id) item_name,indent_qty from shortage_info
where sale_inv_no=@sale_inv_no
union
select sale_inv_no,''new id'' item_id,med_name item_name,qty from newmedicine where item_id=''NEW'' 
and sale_inv_no =@sale_inv_no) x 
inner join (select * from sale_master 
where  sale_inv_no=@sale_inv_no) salemaster on x.sale_inv_no=salemaster.sale_inv_no
left outer join sale_items si on x.sale_inv_no=si.sale_inv_no and si.item_id=x.item_id order by si.auto_id
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pMigrateData]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[pMigrateData]
As
 /*
  --advertise info
  insert into adv_info
  SELECT auto_id,Heading, advmatter, status, cr_date FROM old_data..adv_info
  
  --Audit_Info
  insert into Audit_Info
  SELECT  audit_date, Item_id, Item_Name, Pack_size, Pack_Qty, phy_stock, comp_stock, remarks, audit_by
  FROM    old_data..Audit_Info
  
  --Audit Short Items
  insert into AuditShortItems
  SELECT  Unit_Id, Item_Id, Item_name, Master_key_id, ShortQty, Extra_Qty, m_batch, m_expiry, m_Pack, Remarks, Cr_Date, updated
  FROM    old_data..AuditShortItems
  
  --Card Info
  insert into Card_Info
  SELECT  Card_No, Card_Type, Cust_Name, D_O_B, Area, Locality, District, State, Country, PhoneNo, MobileNo, Act_Date
  FROM    old_data..Card_Info
  
  --Card Info
  insert into Card_History(Card_No, Spouse_Name, Child_Name_1, Child_Name_2, Child_Name_3, 
                      Child_Name_4, Child_Name_5)
  SELECT  Card_No, Spouse_Name, Child_Name_1, Child_Name_2, Child_Name_3,
                      Child_Name_4, Child_Name_5
  FROM    old_data..Card_history
  


  --Config
  insert into config
  SELECT  Shop_Code unit_id, Shop_Name, Comp_Name, Address, Phone, Fax, last_inv_no, CST_NO, DL_NO, UPTT_No, Fin_Year, Books_From, Books_To, vat, LastVoucherNo, lastpurid, 
          pur_code, PharmacistRegNo, Shop_Name StateName, district, PrinterType
  FROM    old_data..config
  
  --Item Master
  insert into Item_Master
  SELECT  Item_id, Mfd_Id, Item_Name, gr_item, Pack_Type, Pack_Qty, Shelf_No, S_Tag, E_Tag, Vend_Code, Rol, Le_Date, CreatedBy, Discount, op_stock,''N'' trfstk
  FROM    old_data..Item_Master
  
  --LoginUser
  insert into Login_Users
  SELECT  User_Name, Password, user_code, Access_Level, status
  FROM    old_data..Login_Users
  
  --Mfd Master
  insert into Mfd_Master
  SELECT  Mfd_id, Mfd_Name, Address, Status, Cr_Date, CreatedBy
  FROM    old_data..Mfd_Master
  
  --Mfd Master
  insert into NewMedicine
  SELECT  Shop_Id, Med_Name, qty, Status, cr_date, Item_id, Sale_inv_no
  FROM    old_data..NewMedicine
  
  --Mfd Master
   insert into purchase_return
   SELECT item_id, master_key_id, vend_code, ld_name, quantity, packs,[transfer], cr_date
   FROM   old_data..purchase_return
  
   --Rcpt_Items
   insert into Rcpt_Items
   SELECT master_key_id, Trf_id, trf_date, Trf_From, Trf_To, item_id, item_name, gr_item, discount, pack_type, pack_qty, rol, batch_no, exp_date, ptr, npr, mrp, 
   taxid, unit_tax_cst, unit_tax_uptt, unit_tax_updt, unit_pur_rate, unit_sale_rate, qty, RcptQty, mfd_id, mfd_name, RcptOk, RcptTrf, ho_shelfno, createdby
   FROM   old_data..Rcpt_Items
   
   -- Ref_Data
   insert into Ref_Data
   SELECT REFBY, REF_NAME, ADDRESS
   FROM old_data..Ref_Data
   
   -- SALE master
   insert into Sale_master
   SELECT  UnitCode Unit_id, Sale_Inv_No, Sale_Date, RefBy, Ref_Name, pt_name, total, discount, net, roundoff, Received, sv, pv, op_margin,
   0 tax_state,0 TaxableMed,0 tax_med,0 TaxableFood,0 tax_food, total_tax, Paid_Tax, Tax_Realize,transfer trf_flag,''N'' lock_flag,''CA'' Pay_Mode,Card_no,
   ''N'' hd_Flag,''-'' rcmOrderNo,createdby login_id,''-'' credit_card_no
   FROM    old_data..Sale_Master
   
   -- SALE Items
   insert into Sale_Items
   SELECT unitcode unit_id, Master_key_id, Sale_Inv_No, Sale_Date, Item_id, Tax_Id,0 tax_rate,Pack_Mrp/Pack_Qty SR, dis_per, Sale_qty, SV, PV, Amount, TAX taxValue,CreatedBy login_id, transfer trf_flag
   FROM   old_data..Sale_Items
   
   --shop master
   insert into shop_master
   SELECT sh_code ,sh_name, sh_address, sh_op_date, UnitAct, shop_head, warehouse_id
   FROM   old_data..shop_master

   --Stocks
   insert into Stocks
   SELECT warehouse unit_id, Item_id, master_key_id, Quantity,Status status_flag, CreatedBy login_id, Cr_Date
   FROM   old_data..Stocks
   
   --Stocks Mismatch
   insert into StocksMismatch
   SELECT master_key_id, warehouse, Item_id, Pack_Type, Pack_Qty, Batch_No, Exp_Date, PTR, NPR, MRP, TaxId, Tax_Cst, unit_tax_cst, Tax_Uptt, 
   unit_tax_uptt, Tax_Updt, unit_tax_updt, unit_pur_rate, unit_sale_rate, Quantity, PV, Status, Cr_Date, CreatedBy
   FROM old_data..StocksMismatch
   
   --TaxConfig
   insert into TaxConfig
   SELECT tax_id, tax_detail, cst, Vat, updt
   FROM   old_data..TaxConfig
   
   --Trf_Items
   insert  into Trf_Items
   SELECT  master_key_id, Trf_id, trf_date, Trf_From, Trf_To, item_id, qty, locked lock_flag, createdby login_id
   FROM    old_data..Trf_Items
   
   --Trf Items Mismatch
   insert  into Trf_ItemsMismatch
   SELECT  master_key_id, Trf_id, trf_date, Trf_From, Trf_To, item_id, item_name, pack_type, pack_qty, rol, batch_no, exp_date, ptr, npr, mrp, taxid, 
           unit_tax_cst, unit_tax_uptt, unit_tax_updt, unit_pur_rate, unit_sale_rate, qty, mfd_id, mfd_name, createdby
   FROM    old_data..Trf_ItemsMismatch
  
   --Trf master 
   insert into Trf_Master
   SELECT Trf_id, trf_from, trf_to, trf_date, no_of_item, createdby,1
   FROM   old_data..Trf_Master
  
  
  
  */
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetCurrentTaxRate]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[pGetCurrentTaxRate]
@unit_id varchar(10),
@tax_id varchar(2),
@tax_rate money =0 output
as
set nocount on;
begin
	if exists(select unit_id from config where stateName=''uttar pradesh'' and unit_id=@unit_id)
	begin
		if @tax_id in (1,2,3,4,5,6,7,8,9,13,15,19,20,22) 
			set @tax_rate=5
		else if @tax_id in (10,11,12,14,16,21,23)
			set @tax_rate=13.5
	end
	else if exists(select unit_id from config where stateName=''delhi'' and unit_id=@unit_id)
	begin
		if @tax_id in (1,2,3,4,5,6,7,8,9,13,15,19,20,22) 
			set @tax_rate=5
		else if @tax_id in (10,11,12,14,16,21,23)
			set @tax_rate=12.5	
	end
	else if exists(select unit_id from config where stateName=''madhya pradesh'' and unit_id=@unit_id)
	begin
		if @tax_id in (1,2,3,4,5,6,7,8,9,13,15,19,20,22) 
			set @tax_rate=5
		else if @tax_id in (10,11,12,14,16,21,23)
			set @tax_rate=13	
	end
	
	else if exists(select unit_id from config where stateName=''uttra khand'' and unit_id=@unit_id)
	begin
		if @tax_id in (1,2,3,4,5,6,7,8,9,13,15,19,20,22) 
			set @tax_rate=4.5
		else if @tax_id in (10,11,12,14,16,21,23)
			set @tax_rate=13.5	
	end

end
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetNewInvoiceNo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- pGetNewInvoiceNo ''MS-00033'',''Auto Generate''
CREATE Procedure [dbo].[pGetNewInvoiceNo]
(
@unit_id varchar(10) ,
@SalesInvNo varchar(16)=''N/A'' output
)
as
set nocount on;
BEGIN
declare @Invoice_no_temp bigint,@Invoice_no varchar(15),@finyear varchar(5),@unitNo varchar(3)
select @Invoice_no_temp=Last_Inv_No,@finyear=fin_year,@unitNo=right(unit_id,3) from config where unit_id=@unit_id
set @Invoice_no_temp=@Invoice_no_temp+1
set @Invoice_no = @unitNo+Right(''0000000'' + lTrim(str(@Invoice_no_temp)), 6) + ''/'' + @finyear
update config set last_inv_no=@Invoice_no_temp where  unit_id=@unit_id;
set @SalesInvNo=@Invoice_no;
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetNewVoucherNo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[pGetNewVoucherNo]
@unit_id varchar(10)=''MS-00033'',
@VoucherNo varchar(16) output
as
declare @finyear varchar(5),@lastvoucherno bigint
set nocount on
set @finyear=dbo.fnGetFinYear(getdate())
select @lastvoucherno=isnull(LastVoucherNo,0) from config where unit_id=@unit_id;
set @lastvoucherno=@lastvoucherno+1
Update config set lastvoucherno=@lastvoucherno  where unit_id=@unit_id;

set @VoucherNo = right(@unit_id,3)+Right(''0000000'' + lTrim(str(@lastvoucherno)), 6) + ''/'' + @FinYear
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetBillInfoForLaser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--select * from sale_items where sale_inv_no=''033038921/11-12''

-- pGetBillInfoForLaser ''MS-00033'',''033041815/11-12''
CREATE Procedure [dbo].[pGetBillInfoForLaser]
@unit_id varchar(10),
@Bill_No varchar(16)=''N/A''
as
set nocount on;
declare @StateName varchar(15);
select @StateName=StateName from config where unit_id=@unit_id;

select  sm.Sale_Inv_No,Sale_Date,Ref_Name,pt_name,Total,Discount,Net,RoundOff,Received,Card_No,
login_id,Pay_Mode,Shop_Name,Comp_Name,Address,Phone,DL_No,Pharma_Reg_No,tax.Tax,vatMed,vatFood,vatExmt,sat
from 
(
	select Sale_Inv_No,Sale_Date,pt_name,Total,Discount,Net,RoundOff,Received,Card_No,
	login_id,Pay_Mode,Tax_realize Tax,sale_master.total_tax,
	Shop_Name,Comp_Name,Address,Phone,DL_No,PharmacistRegNo Pharma_Reg_No,
	CASE 
	WHEN ref_name=''Self'' THEN ''Distt.Hosp.'' 
	WHEN ref_name<>''Self'' THEN ref_name
	END as ref_name
	from sale_master inner join config on sale_master.Unit_id=config.unit_id where sale_inv_no=@Bill_No
) sm 
inner join 
(
	select sale_inv_no,sum(taxValue) tax,
	sum(case when tax_rate=5 then round(taxValue,4) else 0 end) vatMed,
	sum(case when tax_rate=13.5 then round(taxValue,4) else 0 end) vatFood,
	sum(case  when tax_rate=0 then 0 else 0 end) vatExmt,
	sum(case  when tax_rate in (5,13.5) and @StateName=''Uttar Pradesh'' then round(sv-(sv*100)/(100+1),4) else 0 end) sat
	from sale_items where sale_inv_no=@Bill_No
	group by sale_inv_no
) tax on sm.sale_inv_no=tax.sale_inv_no



SELECT     left(im.Item_Name,25) item_name, mki.batch_no, 
case when month(mki.exp_date)=1900 then ''N/A'' else right(convert(varchar(10),mki.Exp_Date,5),5) end exp_date, si.Sale_qty,
isnull(si.Dis_Per,0) Dis_Per, mki.Mrp,si.SR unit_mrp,
 mki.Pack_Qty, round(si.amount,2) as amount ,left(isnull(dbo.Mfd_Master.Mfd_Name,''-''),10) as  mfd_name,
isnull(im.Shelf_No,''-'') as Shelf_No,round(taxValue,4) taxValue,si.tax_rate,
case when si.tax_rate=5 then ''4+1'' else case when si.tax_rate=13.5 then ''12.5+1'' else ''Nil'' end end TaxApply ,(amount-sv) discount
FROM         dbo.Sale_Items si 
INNER JOIN dbo.Item_Master im ON si.Item_id = im.Item_id 
INNER JOIN dbo.Mfd_Master ON im.Mfd_Id = dbo.Mfd_Master.Mfd_id 
inner join MasterKey_Info mki on si.Master_key_id=mki.master_key_id
WHERE     (si.Sale_Inv_No = @bill_no) order by im.Shelf_No

if exists (select Heading,AdvMatter from adv_info where status=''Y'')
select Heading,AdvMatter from adv_info where status=''Y''
else
select ''Attention Please !'' Heading,''[Master Helath Check-up Just For Rs. 799 (Complete Haemogram,Blood Group Routine, and Microscopic, Chect X-Ray,Fasting Blood Sugar & PP Blood Sugar, Lipid Profile,E.C.G.,Blood Pressure,Urea, Creatinnine, SGOT,SGPT, Bilirubin, Hepatitis B (HBsAg).]'' AdvMatter
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pCheckLogin]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create PROCEDURE [dbo].[pCheckLogin]
@emp_code varchar(10),
@Login_pass varchar(10),
@rights varchar(10)=''Operator'' output,
@result varchar(25)=''N/A'' output
as
if exists (select * from Login_Users where  user_code=@emp_code AND [password]=@Login_pass)
begin
select @result=''Login Successfully.''
select @rights=access_level from login_users where user_code=@emp_code
end
else
begin
select @result=''Login Failed.''
end
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pReplaceItemWithNew]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'


CREATE PROCEDURE [dbo].[pReplaceItemWithNew] 
@Item_id_New varchar(7),
@Item_Id varchar(7),
@Item_Name varchar(50),  
@Mfd_Id varchar(7),
@Mfd_Name varchar(50),
@address varchar(50),
@gr_item varchar(10), 
@Pack_Type varchar(20),
@Pack_Qty int,
@result varchar(20)=''N/A'' output
AS
SET NOCOUNT ON;
set @result=''Successfully Replaced.''
begin tran
BEGIN
if (select count(item_id) from item_master where item_id=@item_id_new)=0
begin
      insert into item_master(item_id,item_name,mfd_id,gr_item,pack_type,pack_qty) 
      values(@Item_id_New,@item_name,@mfd_id,@gr_item,@pack_type,@pack_qty)
      if not exists(select mfd_id from Mfd_master where mfd_id=@mfd_id)
      insert into Mfd_Master(mfd_id,mfd_name,address) values(@mfd_id,@mfd_name,@address)

	  delete from item_master where item_id=@item_id
end
else
begin
	update item_master set item_name=@item_name,mfd_id=@mfd_id,gr_item=@gr_item,
	pack_type=@pack_type,pack_qty=@pack_qty where item_id=@item_id_new
	delete from item_master where item_id=@item_id
end

if (select count(item_id) from stocks where item_id=@item_id)>0
	update stocks set item_id=@item_id_new where item_id=@item_id
if (select count(item_id) from trf_items where item_id=@item_id)>0
	update trf_items set item_id=@item_id_new where item_id=@item_id 
if (select count(item_id) from rcpt_items where item_id=@item_id)>0
	update rcpt_items set item_id=@item_id_new where item_id=@item_id 
if (select count(item_id) from sale_items where item_id=@item_id)>0
	update sale_items set item_id=@item_id_new where item_id=@item_id 
if (select count(item_id) from masterkey_info where item_id=@item_id)>0
	update masterkey_info set item_id=@item_id_new where item_id=@item_id 

END

if(@@error=0)
commit
else
begin
rollback
set @result=''Failed To Replace.''
end' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pSelectQueries]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- pSelectQueries ''chcl-00033'',''StockListSearchByName'',''A'',''N/A'',''N/A'',''chcl-00009''
CREATE Procedure [dbo].[pSelectQueries]
@unit_id varchar(10),
@prm_1 varchar(50)=''N/A'',
@prm_2 varchar(50)=''N/A'',
@prm_3 varchar(50)=''N/A'',
@prm_4 varchar(50)=''N/A'',
@login_id varchar(10)
as
set nocount on;
if(@prm_1=''Purchase:ProductSearch'')
begin
	select top 30 im.item_id,im.item_name, left(mm.mfd_name,10) mfd_name
	from         dbo.item_master im 
	inner join dbo.mfd_master mm on im.mfd_id = mm.mfd_id
	and item_name like @prm_2+''%'' 
	order by im.item_name;
end
else if(@prm_1=''Import:VerifyQtyAgainstMasterkey'')
begin
	select rcptok,rcptqty,rcpttrf 
	from rcpt_items 
	where trf_id=@prm_2 and master_key_id=@prm_3 
end
else if(@prm_1=''TransferId:TransferIdInfo'')
begin
	select master_key_id,item_id,item_name,pack_type,pack_qty,batch_no,exp_date,
	ptr,npr,mrp,qty,mfd_id,mfd_name,gr_item,rcptok,ho_shelfno
	from rcpt_items 
	where trf_id=@prm_2
end
else if(@prm_1=''TransferId:TransferIdInfo_2'')
begin
	select master_key_id,rcptQty,qty from rcpt_items 
	where trf_id=@prm_2
end
else if(@prm_1=''StockListSearchByName'')
begin
SELECT   top 10 unitStocks.unit_id, unitStocks.Item_id,  im.Item_Name, mm.Mfd_Name, im.Shelf_No, unitStocks.Cl_Qty qty
FROM (	SELECT   unit_id, Item_id, SUM(Quantity) AS Cl_Qty 
		FROM dbo.Stocks 
		GROUP BY unit_id,Item_id
	) AS unitStocks 
INNER JOIN dbo.Item_Master im on unitStocks.Item_id = im.Item_id 
INNER JOIN dbo.Mfd_Master mm ON im.Mfd_Id = mm.Mfd_id 
where unit_id=@unit_id and cl_qty>0 and item_name like @prm_2+''%'' 
order by item_name
end
else if(@prm_1=''GoodsReturnInfo'')
begin
select im.item_id,gr.master_gr_no,gr.gr_no,gr.master_key_id,left(im.item_name,30) item_name, 
mki.batch_no,mki.exp_date,mki.pack_type,gr.qty,mki.ptr,mki.mrp,im.shelf_no,mki.pack_qty from 
goodsreturn gr inner join stocks st on st.master_key_id=gr.master_key_id
inner join masterkey_info mki on mki.master_key_id=st.master_key_id
inner join item_master im on im.item_id=mki.item_id
where gr.master_gr_no=@prm_2 and gr.unit_id=@unit_id
end
else if(@prm_1=''CashMemoHeadInfo'')
begin
select refby,pt_name,ref_name,card_no from sale_master where Pay_Mode=''CA'' and sale_inv_no=@prm_2
end
else if(@prm_1=''SearchReferral'')
begin
select REF_NAME,REFBY from ref_data where ref_name like @prm_2+''%'';
end
else if(@prm_1=''Sales:UnPosted'')
begin
select distinct sale_inv_no from t_sale_items where unit_id =@unit_id;
end
else if(@prm_1=''SaleItems:Not Transfered'')
begin
	select unit_id, Master_key_id, Sale_Inv_No, Sale_Date, Item_id, Tax_Id, tax_rate, 
	SR, dis_per, Sale_qty, SV, PV, Amount, taxValue, login_id, trf_flag
	FROM dbo.Sale_Items where unit_id=@unit_id and trf_flag=''N''
end
else if(@prm_1=''SaleMaster:Not Transfered'')
begin
	select Unit_id, Sale_Inv_No, Sale_Date, RefBy, Ref_Name, pt_name, total, discount, net, roundoff, Received, sv, pv, op_margin, tax_state, TaxableMed, 
	tax_med, TaxableFood, tax_food, total_tax, Paid_Tax, Tax_Realize, trf_flag, lock_flag, Pay_Mode, Card_no, hd_Flag, rcmOrderNo, login_id
	FROM  Sale_Master where unit_id=@unit_id and trf_flag=''N''
end
else if(@prm_1=''Search:Sold Product'')
begin
	SELECT DISTINCT TOP 20 dbo.Item_Master.Item_id, dbo.Item_Master.Item_Name 
	FROM dbo.Item_Master 
	INNER JOIN dbo.Sale_Items ON dbo.Item_Master.Item_id = dbo.Sale_Items.Item_id 
	where dbo.Item_Master.Item_Name like @prm_2 + ''%'' and convert(varchar(10),Sale_Date,111) between @prm_3 and  @prm_4;
end
else if(@prm_1=''Search:Sold Product With Invoice'')
begin
	SELECT TOP 50 dbo.Sale_Items.Item_id, dbo.Sale_Master.Sale_Date, dbo.Sale_Master.Sale_Inv_No, 
	dbo.Sale_Master.pt_name, dbo.Sale_Master.total,dbo.Sale_Master.discount, dbo.Sale_Master.net,dbo.Sale_Master.received
	FROM dbo.Sale_Master 
	INNER JOIN dbo.Sale_Items ON dbo.Sale_Master.Sale_Inv_No = dbo.Sale_Items.Sale_Inv_No 
	where convert(varchar(10),dbo.Sale_Master.Sale_Date,111) between @prm_2 and  @prm_3 and dbo.Sale_Items.item_id=@prm_4
	ORDER BY dbo.Sale_Master.Sale_Date desc;
end
else if(@prm_1=''Search:Fill Invoice Info'')
begin
	SELECT dbo.Item_Master.item_id,mki.batch_no, mki.Exp_Date, sale_items.sv amount, sale_items.sale_Qty,card_no,  
	dbo.Item_Master.Item_Name 
	FROM dbo.Sale_Items 
	INNER JOIN  dbo.Sale_Master ON dbo.Sale_Items.Sale_Inv_No = dbo.Sale_Master.Sale_Inv_No 
	INNER JOIN dbo.Item_Master ON dbo.Sale_Items.Item_id = dbo.Item_Master.Item_id 
	inner join masterkey_info mki on mki.master_key_id= dbo.Sale_Items.master_key_id
	WHERE     (dbo.Sale_Items.Sale_Inv_No  = @prm_2) 
end
else if(@prm_1=''Shelf:Only Shelf Nos'')
begin
	select distinct shelf_no from item_master order by shelf_no
end
else if(@prm_1=''Shelf:Shelf Products'')
begin
   SELECT dbo.Item_Master.Item_Name,item_master.shelf_no,mki.Exp_Date, mki.Batch_No, stocks.Quantity 
   FROM  dbo.Stocks 
   INNER JOIN dbo.Item_Master ON dbo.Stocks.Item_id = dbo.Item_Master.Item_id
   INNER JOIN masterkey_info mki ON dbo.Stocks.master_key_id = mki.master_key_id
   where stocks.quantity>0 and item_master.shelf_no=@prm_2 
   order by dbo.Item_Master.Item_Name
end
else if(@prm_1=''Item:StocksInfo'')
begin
	select mki.master_key_id,mki.batch_no,mki.exp_date,mki.mrp,mki.npr,mki.tax_id,mki.pack_type,mki.pack_qty, 
	mki.upr,st.quantity 
	from Stocks st
	inner join masterkey_info mki on st.master_key_id=mki.master_key_id 
	where mki.item_id=@prm_2 and quantity>0;
end
else if(@prm_1=''Item:Product List'')
begin
	select item_id,item_name from item_master 
end
else if(@prm_1=''GR:CheckMasterKeyId'')
begin
	select cr_date trf_date,''PND'' vType,''GR(T)'' aType,0 inStk,quantity outStk,''In Temp GR'' Remarks from purchase_return where master_key_id=@prm_2 and unit_id=@unit_id
end
else if(@prm_1=''Shelf_Nos'')
begin
    select distinct isnull(Shelf_No,''N/A'') as shelf_no,isnull(Shelf_No,''N/A'') as shelf from item_master where item_id in
    (select distinct item_id from stocks where unit_id=@unit_id) order by shelf_no
end
else if(@prm_1=''SearchInShelf_No'')
begin
	if (@prm_2!=''Select'')
		select top 30 item_id,item_name from item_master where item_name like @prm_3 and shelf_no=@prm_2 order by item_name 
	else
		select top 30 item_id,item_name from item_master where item_name like @prm_3+''%''  order by item_name 
end
else if(@prm_1=''Expiry:Vendor List'')
begin
     select distinct ld_name,ld_code from goodsreturn where master_gr_no=@prm_2 order by ld_name
end
else if(@prm_1=''Expiry:Master Gr No'')
begin
	select mki.item_id,gr.master_gr_no,gr.gr_no,gr.master_key_id,left(im.item_name,30) item_name, 
					mki.batch_no,mki.exp_date,mki.pack_type,mki.pack_qty,gr.qty, gr.pack,mki.ptr,mki.mrp, ld_name,purch_info, 
					shelf_no
	from goodsreturn gr inner join stocks st on st.master_key_id=gr.master_key_id 
	inner join masterkey_info mki on gr.master_key_id=mki.master_key_id
	inner join item_master im on im.item_id=mki.item_id
	where gr.unit_id=@unit_id and gr.master_gr_no=@prm_2 
end
else if(@prm_1=''Expiry:Vendor Slip'')
begin
	select mki.item_id,gr.master_gr_no,gr.gr_no,gr.master_key_id,left(im.item_name,30) item_name, 
					mki.batch_no,mki.exp_date,mki.pack_type,mki.pack_qty,gr.qty,gr.pack,mki.ptr,mki.mrp, ld_name,purch_info, 
					shelf_no
	from goodsreturn gr inner join stocks st on st.master_key_id=gr.master_key_id 
	inner join masterkey_info mki on gr.master_key_id=mki.master_key_id
	inner join item_master im on im.item_id=mki.item_id
	where gr.unit_id=@unit_id and gr.master_gr_no=@prm_2 and gr.ld_code=@prm_3 order by im.item_name
end
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pSyncItem_Master]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create Procedure [dbo].[pSyncItem_Master]
@item_id varchar(10),
@item_name varchar(50),
@pack_type varchar(15),
@pack_qty int,
@gr_item varchar(15),
@discount money,
@mfd_id varchar(10),
@mfd_name varchar(50),
@login_id varchar(10)
as
set nocount on;
update  item_master set item_name=@item_name, mfd_id=@mfd_id,
gr_item=@gr_item,pack_type=@pack_type,pack_qty=@pack_qty,
discount=@discount  where item_id=@item_id
if not exists(select mfd_id from mfd_master where mfd_id=@mfd_id)
insert into mfd_master(mfd_id,mfd_name,Address,status,createdBy) 
values (@mfd_id,@mfd_name,''-'',''-'',@login_id)
else 
update mfd_master set mfd_name=@mfd_name where mfd_id=@mfd_id
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetMinimumPurchaseOrder]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[pGetMinimumPurchaseOrder]
@unit_id varchar(10)
as
set nocount on;
select soldqty,pot.item_id,im.item_name,im.pack_qty,im.pack_type,pot.wh_qty,pot.stockinpacks,pot.stock_qty,
pot.order_pack,pot.sale_avg,mm.mfd_id,mm.mfd_name,pot.npr,pot.last_sale_date
from PurchOrderTemp pot 
inner join item_master im on pot.item_id=im.item_id
inner join Mfd_Master mm on mm.mfd_id=pot.mfd_id
where pot.unit_id=@unit_id
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pProductHelp]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--pProductHelp ''Disp'',''MS-00033''
CREATE Procedure [dbo].[pProductHelp] 
@search varchar(50),
@unit_id varchar(10)
as
set nocount on;
if(len(@search)>2)
begin
	select  Item_id,Item_Name, mfd_name, shelf_no, qty, gr_item from 
	( SELECT  top 30   dbo.Item_Master.Item_Name, left(dbo.Mfd_Master.Mfd_Name,10) mfd_name, isnull(shelf_no,''N/A'') as shelf_no, 
	stockqty.Cl_Qty AS qty,stockqty.Item_id, dbo.Item_Master.gr_item 
	FROM   dbo.Item_Master INNER JOIN  dbo.Mfd_Master ON dbo.Item_Master.Mfd_Id = dbo.Mfd_Master.Mfd_id 
	INNER JOIN (select stocks.item_id,sum(stocks.quantity) cl_qty from stocks 
	inner join item_master im on stocks.item_id=im.item_id 
	inner join masterkey_info mki on stocks.item_id=mki.item_id and stocks.master_key_id=mki.master_key_id
	where unit_id=@unit_id and (convert(varchar(10),mki.exp_date,111)=''1900/01/01'' or (DATEDIFF(month, GETDATE(), mki.Exp_Date)) >= 1 ) 
	and (item_name like @search+'' %'' or item_name like '' ''+@search or item_name like '' ''+@search+''%''  or item_name like ''% ''+@search+'' %'' or 
	item_name like @search+''%'' or item_name like ''%''+@search+''%'' ) group by stocks.item_id) stockqty 
	ON dbo.Item_Master.Item_id = stockqty.Item_id ) CurStock 
	order by item_name 
end
else
begin
	select Item_id,Item_Name, mfd_name, shelf_no, qty, gr_item  from 
	( SELECT  top 30   dbo.Item_Master.Item_Name,left(dbo.Mfd_Master.Mfd_Name,10) mfd_name, isnull(shelf_no,''N/A'') as shelf_no, 
	stockqty.Cl_Qty AS qty,stockqty.Item_id, dbo.Item_Master.gr_item 
	FROM   dbo.Item_Master INNER JOIN  dbo.Mfd_Master ON dbo.Item_Master.Mfd_Id = dbo.Mfd_Master.Mfd_id 
	INNER JOIN (select stocks.item_id,sum(stocks.quantity) cl_qty from stocks 
	inner join item_master im on stocks.item_id=im.item_id 
	inner join masterkey_info mki on stocks.item_id=mki.item_id and stocks.master_key_id=mki.master_key_id
	where unit_id=@unit_id and (mki.exp_date=''1900-01-01'' or (DATEDIFF(month, GETDATE(), mki.Exp_Date)) >= 1 ) 
	and left(item_name,2)=@search group by stocks.item_id) stockqty 
	ON dbo.Item_Master.Item_id = stockqty.Item_id ) CurStock 
	order by item_name 
end
' 
END
GO
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pImportInToStock]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pImportInToStock]
@unit_id varchar(10),
@trf_id varchar(16),
@item_id varchar(7),
@master_key_id varchar(16),
@qty money,
@result varchar(20)=''N/A'' output
as
set nocount on;
declare @voucherno varchar(12),
	@lastvoucherno int,@debit int,@credit int,@amount money,
	@trfdate datetime, @expdate datetime,@ptr money,@npr money,	@mrp money,
	@upr money,	@usr money,@otherstate varchar(1),@itemname varchar(50),@batchno varchar(10),@mfd_id varchar(10),
	@mfd_name varchar(50),@packtype varchar(10),@packqty money,@ShelfNo varchar(10),@pGroup varchar(10),@Discount int

set @result=''Error to Insert'';
if exists (select count(item_id) from rcpt_items where trf_id=@trf_id AND   trf_from in (@unit_id,(select distinct unit_id from shop_master)))
set @otherstate=''N''
else
set  @otherstate=''Y''

if not exists(select item_id from rcpt_items where  trf_id=@trf_id and item_id=@item_id and master_key_id=@master_key_id and rcpttrf=''Y'')
begin
	--Get NetAmountFrom Rcpt_Items
	select @amount=sum(unit_pur_rate*qty)  from rcpt_items  where trf_id=@trf_id and item_id=@item_id and  master_key_id=@master_key_id
	select @expdate=exp_date,@packtype=pack_type,@packqty=pack_qty,@ptr=ptr,@npr=npr,@mrp=mrp,@upr=unit_pur_rate,@usr=unit_sale_rate,
	@mfd_id=mfd_id,@mfd_name=mfd_name,@itemname=item_name,@pGroup=gr_item
	from rcpt_items where  trf_id=@trf_id and item_id=@item_id and  master_key_id=@master_key_id 
	--Update Item_Master
	if exists(select item_id from item_master  where  item_id=@item_id)
	begin
    		update item_master set item_name=@itemname,mfd_id=@mfd_id,pack_type=@PackType,pack_qty=@packqty,gr_item=@pGroup,discount=isnull(@discount,0) where item_id=@item_id
	end
	Else
	begin
    		insert into item_master (item_id,item_name,mfd_id,pack_type,pack_qty,shelf_no,gr_item,Discount) 
    		values (@item_id,@itemname,@mfd_id,@PackType,@packqty,''C/''+ltrim(@shelfno),@pGroup,isnull(@discount,0))
	End

	--Update Mfd Master
	if exists(select mfd_id from mfd_master  where  mfd_id=@mfd_id )
	begin
    		update mfd_master set mfd_name=@mfd_name   where mfd_id=@mfd_id 
	end
	Else
	begin
    		insert into mfd_master (mfd_id,mfd_name) values (@mfd_id ,@mfd_name)
	End 
	
	--update master_key_info
	if not exists(select master_key_id from masterkey_info where master_key_id=@master_key_id)
	begin
		insert into MasterKey_Info (
				item_id, master_key_id, pack_type, pack_qty, mrp, npr, ptr, upr          , usr          , exp_date, batch_no, 
				tax_id, barcode_no, tax_rate, upd_date)         
  		select  item_id, master_key_id, pack_type, pack_qty, mrp, npr, ptr,unit_pur_rate ,unit_sale_rate, exp_date, batch_no, 
   				taxid,master_key_id,0,getdate()
   		from rcpt_items where item_id=@item_id  and master_key_id=@master_key_id and trf_id=@trf_id
	end
	--Update Stocks
	if exists(select master_key_id from stocks where master_key_id=@master_key_id and unit_id=@unit_id ) 
	begin
    		Update stocks set quantity=quantity+@qty where master_key_id=@master_key_id and unit_id=@unit_id 
    		update rcpt_items set rcpttrf=''Y'',rcptQty=@qty where item_id=@item_id  and trf_id=@trf_id and master_key_id=@master_key_id
	end
	Else
	begin
			--update Stocks 
    		insert into stocks (unit_id,master_key_id,item_id,quantity,status_flag,login_id) 
    		select @unit_id ,master_key_id,item_id,qty ,@otherstate,''Imported''
    		from rcpt_items where item_id=@item_id  and master_key_id=@master_key_id and trf_id=@trf_id

		update rcpt_items set rcpttrf=''Y'',rcptQty=@qty where master_key_id=@master_key_id and item_id=@item_id  and trf_id=@trf_id
	End 
end

if(@@error=0)
set @result=''Successfully Inserted.'';
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pCGHSPendingQty]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[pCGHSPendingQty] --''006000338/09-10''
@sale_inv_no varchar(16)
as
set nocount on;
select item_name,short_qty Pending from shortage_info inner join item_master 
on shortage_info.item_id=item_master.item_id
where sale_inv_no=@sale_inv_no and short_qty>0
union
select med_name ,sum(qty) Pending from newmedicine where sale_inv_no=@sale_inv_no and status=''Y''
group by med_name order by item_name
' 
END
GO
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pNewMedicine]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pNewMedicine]

 AS
select * from newMedicine where status=''N'' order by med_name
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pCreateRivision_Info]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create Procedure [dbo].[pCreateRivision_Info]
as
set nocount on;
IF  not exists (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N''[dbo].[Rivision_Info]'') AND type in (N''U''))
begin
	Create Table Rivision_Info (riv_code varchar(2),riv_type varchar(50),riv_no decimal(8,2))
	insert into Rivision_Info(riv_code,riv_type,riv_no) values(''LI'',''Login_Info'',.01)
	insert into Rivision_Info(riv_code,riv_type,riv_no) values(''IM'',''Item Master'',.02)
	insert into Rivision_Info(riv_code,riv_type,riv_no) values(''AP'',''Application'',.01)
end
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateCardInfo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateCardInfo]
@CardNo varchar(20)=null,
@card_type varchar(15)=''Health Card'',
@CustName varchar(50),
@DOB datetime,
@Area varchar(50),
@Locality varchar(50),
@District varchar(20),
@State varchar(20),
@Country varchar(20),
@PhoneNo varchar(20),
@MobileNo varchar(10),
@SpouseName varchar(50)=null,
@child_name_1 varchar(50)=null,
@child_name_2 varchar(50)=null,
@child_name_3 varchar(50)=null,
@child_name_4 varchar(50)=null,
@child_name_5 varchar(50)=null,
@act_date datetime
as

set nocount on
begin transaction
if NOT EXISTS(select * from card_info where card_no=@cardno)
begin
insert into card_info (Card_No,Card_Type,Cust_Name,D_O_B,Area,Locality,District,State,Country,PhoneNo,MobileNo,act_date)
values(@CardNo,@Card_Type,@CustName,@DOB,@Area,@Locality,@District,@State,@Country,@PhoneNo,@MobileNo,@act_date)
end
else
begin
update card_info set cust_name=@custname,mobileno=@mobileno,act_date=@act_date where card_no=@CardNo
end

if not exists(select * from card_history where card_no=@cardno)
insert into card_history (card_no,spouse_name,child_name_1,child_name_2,child_name_3,child_name_4,child_name_5)
values(@cardno,@spousename,@child_name_1,@child_name_2,@child_name_3,@child_name_4,@child_name_5)
else
update card_history set spouse_name=@spousename,child_name_1=@child_name_1,child_name_2=@child_name_2
,child_name_3=@child_name_3,child_name_4=@child_name_4,child_name_5=@child_name_5
where card_no=@cardno

if @@error<>0
begin
rollback
end
else
begin
commit
end
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pCheckHealthCard]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--pCheckHealthCard ''AM000009'',''N/A''
CREATE Procedure [dbo].[pCheckHealthCard]
(
@HealthCardNo varchar(20)=''N/A'',
@status varchar(15) output
)
as
set nocount on;
if exists(select Card_No from Card_Info where Card_No=@HealthCardNo)
begin
select @status =case when act_date>dateadd(year,-1,getdate()) then ''Active'' else ''Active'' end 
from card_info where card_no= @HealthCardNo;
end
else
set @status=''Not Exists'';
print @status
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetHelthCardInfo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- pGetHelthCardInfo ''AM000009''
Create Procedure [dbo].[pGetHelthCardInfo]
@searchString varchar(20)
as
set nocount on;
SELECT top 15 ci.Cust_Name, ci.Locality, ch.Card_No,
ci.D_O_B, ci.MobileNo,  ch.Spouse_name,
ch.Child_Name_1,ch.Child_Name_2, ch.Child_Name_3, 
ch.Child_Name_4, ch.Child_Name_5,   ci.Area,
ci.District, ci.State, 
ci.Country FROM  dbo.Card_History ch INNER JOIN dbo.Card_Info ci ON  
ch.Card_No = ci.Card_No where  
(ci.mobileno like @searchString+''%'' or  ch.Card_No like @searchString+''%'' or ci.cust_name like @searchString+''%'');
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pAuditorWorkInfo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[pAuditorWorkInfo]
@unit_id varchar(10),
@item_id varchar(10)
as
set nocount on;

SELECT s.item_id,mki.master_key_id,mki.batch_no,mki.exp_date,mki.pack_qty,s.quantity FROM STOCKS  s
inner join masterkey_info mki on s.master_key_id=mki.master_key_id 
WHERE s.ITEM_ID=@item_id and unit_id=@unit_id order by quantity desc;

select ad.master_key_id,ad.item_id,mki.batch_no,mki.exp_date,mki.pack_qty,ad.shortqty as shquantity,
ad.extra_qty as exQuantity from auditshortitems ad
inner join stocks on ad.master_key_id=stocks.master_key_id
inner join masterkey_info mki on stocks.item_id=mki.item_id and stocks.master_key_id =mki.master_key_id
where  ad.unit_id=stocks.unit_id and ad.updated=''N'' and ad.item_id=@item_id and 
(ad.shortqty>0 or ad.extra_qty>0) and ad.unit_id=@unit_id;


select item_master.shelf_no,item_master.item_name,sum(stocks.quantity) as stkqty 
from item_master,stocks 
where stocks.item_id=item_master.item_id 
and stocks.item_id=@item_id and stocks.unit_id=@unit_id 
group by stocks.item_id,item_master.shelf_no,item_master.item_name;

' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetSalesInvoiceInfo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- pGetSalesInvoiceInfo ''033041815/11-12''
CREATE PROCEDURE [dbo].[pGetSalesInvoiceInfo]
@Sales_Inv_No varchar(16)=null
AS
set nocount on;
if exists (select Sale_Master.Sale_Inv_No from Sale_Master where Sale_Inv_No=@Sales_Inv_No)
begin
  select Sale_Inv_No,Sale_Date,Ref_Name,refby,Ref_Name,pt_name,total,
  discount,net,roundoff,received,Card_no,hd_Flag,lock_flag
  from sale_master where sale_inv_no=@Sales_Inv_No
  
  select  im.item_name, si.master_key_id, mki.batch_no, mki.pack_type, mki.pack_qty, 
          mki.exp_date, mki.mrp, si.sv, si.item_id, si.tax_id, si.sale_qty,
          (si.SV/si.Sale_qty) unit_rate
  from    dbo.sale_items  si 
  inner join masterkey_info mki on si.master_key_id=mki.master_key_id
  inner join item_master im on im.item_id = si.item_id where si.sale_inv_no=@Sales_Inv_No
end
else if exists (select Sale_Inv_No from t_Sale_Master where Sale_Inv_No=@Sales_Inv_No)
begin
  select Sale_Inv_No,Sale_Date,Ref_Name,refby,Ref_Name,pt_name,total,
  discount,net,roundoff,received,Card_no,hd_Flag,lock_flag
  from t_sale_master where sale_inv_no=@Sales_Inv_No
  
  select  im.item_name, si.master_key_id, mki.batch_no, mki.pack_type, mki.pack_qty, 
          mki.exp_date, mki.mrp, si.sv, si.item_id, si.tax_id, 
          si.sale_qty,(si.SV/si.Sale_qty) unit_rate
  from    dbo.t_Sale_Items  si 
  inner join masterkey_info mki on si.master_key_id=mki.master_key_id
  inner join item_master im on im.item_id = si.item_id where si.sale_inv_no=@Sales_Inv_No
end
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pDeleteSales]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--pDeleteSales ''MS-00033'',''033042998/11-12'',''033001770641112'',''N/A''
CREATE  PROCEDURE [dbo].[pDeleteSales]
@unit_id varchar(10),
@sale_inv_no varchar(16),
@master_key_id varchar(16),
@result varchar(20) output
AS
set nocount on;
set @result=''Not Found'';
declare @confirm table(master_key_id varchar(16),sold_qty int);

delete from t_Sale_Items output deleted.Master_key_id,deleted.Sale_qty into @confirm 
where sale_inv_no=@sale_inv_no and master_key_id =@master_key_id;

if exists(select master_key_id from @confirm) 
begin
	update stocks set quantity=quantity+cnf.sold_qty 
	from @confirm cnf
	where stocks.master_key_id=cnf.master_key_id and unit_id=@unit_id
	--Update t_sale_master 
	execute pUpdate_T_Sale_Master @unit_id,@sale_inv_no,''N/A'';
	
	set @result=''Success'';
end 
 select total,discount,roundoff,(total-discount-roundoff) payable from  t_Sale_Master 
 where sale_inv_no= @sale_inv_no;
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pUpdate_T_Sale_Master]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[pUpdate_T_Sale_Master]
@unit_id varchar(10),
@sales_inv_no varchar(16),
@HealthCardNo varchar(20),
@result varchar(20)=''N/A'' output
AS
set nocount on;
declare @confirm table(sales_inv_no varchar(16))

if exists(select item_id from t_sale_items where sale_inv_no=@sales_inv_no and unit_id=@unit_id)
begin
--select * from t_sale_master
UPDATE t_sale_master SET t_sale_master.total=ISNULL(x.total,0),t_sale_master.discount=
case when x.total=x.payable then 0 else ISNULL(x.total-ISNULL(x.payable,0),0) end ,
t_sale_master.net=ISNULL(x.payable,0),t_sale_master.roundoff=round(x.total,0)-x.total,
t_sale_master.pv=ISNULL(x.pv,0),t_sale_master.sv=x.sv,trf_flag=''N'',
tax_med=x.tax_medicine,tax_food=x.tax_food,op_margin=x.sv-x.pv,Card_no=@HealthCardNo,
received=case when left(@HealthCardNo,4)=''CORP'' then 0 else x.payable end ,
taxableMed=x.taxable_med,taxableFood=x.taxable_food
output inserted.Sale_Inv_No into @confirm
FROM (
	select SALE_INV_NO,round(sum(amount),2) total,sum(amount-sv) discount,
	round(sum(sv),0) payable,
	abs(sum(sv-round(sv,2))) roundoff,
	SUM(pv) pv,SUM(sv) sv,
	isnull(sum(case  when Tax_id IN (7, 8, 9, 13, 15,20,22) then taxValue else 0 end),0) tax_medicine,
	isnull(sum(case  when Tax_id IN (10, 11, 12, 14, 16,21,23) then taxValue else 0 end),0) tax_food,
	isnull(sum(case  when Tax_id IN (7, 8, 9, 13, 15,20,22) then sv-taxValue else 0 end),0) taxable_med,
	isnull(sum(case  when Tax_id IN (10, 11, 12, 14, 16,21,23) then sv-taxValue else 0 end),0) taxable_food,
	sum(case  when Tax_id IN (9,12) then 0 else 0 end) tax_exempted
	from t_sale_items WHERE sale_inv_no=@sales_inv_no  group by sale_inv_no
) x 
WHERE t_sale_master.sale_inv_no=x.sale_inv_no AND t_sale_master.sale_inv_no=@sales_inv_no 

if exists (select sales_inv_no from @confirm)
	set @result=''Success''
else
	set @result=''Fail''
end
else
begin
	UPDATE t_sale_master SET t_sale_master.total=0,t_sale_master.discount=0,
	t_sale_master.net=0,t_sale_master.roundoff=0,t_sale_master.pv=0,t_sale_master.sv=0,trf_flag=''N'',
	tax_med=0,tax_food=0,op_margin=0,Card_no=0,Received=0,
	taxableMed=0,taxableFood=0 where  sale_inv_no=@sales_inv_no 
	set @result=''Success''
end

' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pCashMemoFinalization]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[pCashMemoFinalization]
@unit_id nVarchar(10),
@Sale_Inv_No nVarchar(16)=''N/A'',
@HealthCardNo nVarchar(20),
@rcmOrderNo varchar(16)=''-'',
@hd_flag nVarChar(1)=''N'',
@refBy nVarchar(5),
@ref_name varchar(50)=''N/A'',
@payMode nVarchar(2)=''CA'', --CA:Cash, CC:Credit Card,CH:Checque,CR: Credit
@pt_name nVarchar(50),
@result nVarchar(50)=''N/A'' output
as
set nocount on;
declare @curDate varchar(10)
begin try
begin
	declare @confirm table(result varchar(16))
	set @curDate=convert(varchar(10),getdate(),111);

	if exists(select corp_id from Corp_Cont_Info where corp_id=@HealthCardNo and c_to>getdate() and left(@HealthCardNo,4)=''CORP'')
	begin
		select @ref_name=ltrim(inst_name)+'' [''+corp_id+'']'' from Corp_Cont_Info where corp_id=@HealthCardNo
		set @refby=''NEW'';
	end
	--else
	--begin
	--	select @refby=isnull(refby,''NEW''),@ref_name=ref_name from t_sale_master where sale_inv_no=@sale_inv_no;
	--end

	if(@refBy =''Self'')
		set @ref_name=''Distt. Hospital'';
		
	update  t_sale_master set RefBy=@refBy,Ref_Name=@ref_name,
	Pay_Mode=@payMode,pt_name=@pt_name,Card_no=@HealthCardNo,
	rcmOrderNo=@rcmOrderNo,hd_Flag=@hd_flag,
	Sale_Date=GETDATE()
	where Sale_Inv_No=@Sale_Inv_No;

	--Transfer Sales Master
	insert into sale_master (
	Unit_id, Sale_Inv_No, Sale_Date, RefBy, Ref_Name, pt_name, 
	total, discount, net, roundoff, Received, Pay_Mode, 
	sv, pv, op_margin, tax_state,taxableMed, tax_med,taxableFood,tax_food, total_tax, Paid_Tax, Tax_Realize, 
	trf_flag, lock_flag, Card_no, hd_Flag, rcmOrderNo, login_id)
	output inserted.sale_inv_no into @confirm
	select Unit_id, Sale_Inv_No, Sale_Date, RefBy, Ref_Name, pt_name, 
	total, discount, net, roundoff, Received, Pay_Mode, 
	sv, pv, op_margin, tax_state,taxableMed, tax_med,taxableFood,tax_food, total_tax, Paid_Tax, Tax_Realize, 
	trf_flag, ''Y'', Card_no, hd_Flag, rcmOrderNo, login_id
	from t_Sale_Master 
	where Sale_Inv_No=@Sale_Inv_No;
	
	--Transfer Sales Item
	 insert into sale_items (unit_id, Master_key_id, Sale_Inv_No, Sale_Date, Item_id, Tax_Id, 
	 tax_rate, SR, Sale_qty, SV, PV, Amount, taxValue, login_id, trf_flag)
	 output inserted.sale_inv_no into @confirm
	 select  unit_id, Master_key_id, Sale_Inv_No, Sale_Date, Item_id, Tax_Id, 
	 tax_rate, SR, Sale_qty, SV, PV, Amount, taxValue, login_id, trf_flag
	 from t_Sale_Items where Sale_Inv_No=@Sale_Inv_No;

	if(select count(result) from @confirm)>=2
	begin
		delete  from t_Sale_Master where Sale_Inv_No=@Sale_Inv_No;
		delete  from t_Sale_Items where Sale_Inv_No=@Sale_Inv_No;
	end
    --execute pGenerateSalesSummary @unit_id,@curDate;
	--execute pAC_GenerateBooks @unit_id,@curDate,@curDate,''Y'',''Y'';
	set @result=''Successfully Completed.''
end
end try
begin catch
	DECLARE @ErrorMessage NVARCHAR(4000);
	SELECT @ErrorMessage = ERROR_MESSAGE();
	RAISERROR (@ErrorMessage, 16, 1);
	set @result=''Failed To Complete'';
end catch




 



' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGenerateSalesSummary]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create Procedure [dbo].[pGenerateSalesSummary]
@unit_id varchar(10),
@sale_date varchar(10)
as
set nocount on;
delete from daily_sales_summary where unit_id=@unit_id and convert(varchar(10),sale_date,111)=convert(varchar(10),@sale_date,111)
insert into daily_sales_summary
select unit_id,convert(varchar(10),sale_date,111) sale_date,
sum(case when total>0 and received!=0 then round(total,0) else 0 end) sales,
sum(case when discount>0  and received!=0 then round((total-received),0) else 0 end) discount,
abs(sum(case when total<0  and received!=0 then  round(total,0) else 0 end)) sales_return,
abs(sum(case when discount<0  and received!=0 then round((total-received),0) else 0 end)) discount_return,
sum(case when received>0 then received else 0 end) Cash,
abs(sum(case when received<0 then received else 0 end)) Cash_Return,
--Credit Sales
sum(case when total>0 and received=0 then round(total,0) else 0 end) cr_sales,
sum(case when discount>0  and received=0 then round((total-received),0) else 0 end) cr_discount,
abs(sum(case when total<0  and received=0 then  round(total,0) else 0 end)) cr_sales_return
from sale_master where convert(varchar(10),sale_date,111)=convert(varchar(10),@sale_date,111) and unit_id=@unit_id
group by unit_id,convert(varchar(10),sale_date,111)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockImport_AC_Posting]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[StockImport_AC_Posting]
@trf_id varchar(15),
@shop_code varchar(10),
@voucher_no varchar(16),
@operator varchar(15),
@result varchar(100)=null  output
AS

declare @dr_ledg_code int,
	@cr_ledg_code int,
	@amount decimal,
	@warehouse_id varchar(10),
	@vch_date datetime
if not exists (select * from vouchermaster where unit_id=@shop_code and  narration like ''%''+ltrim(@trf_id)+''%'')	
update rcpt_items set rcptok=''N'' where trf_id=@trf_id
	
if  (select  count(*)  from rcpt_items where rcpttrf=''Y'' and rcptok!=''Y''  and trf_id=@trf_id and trf_from!=@shop_code)>0
begin	
	set @vch_date=convert(varchar(10),getdate(),111) 
	select @warehouse_id =warehouse_id from shop_master where sh_code=@shop_code
	select @cr_ledg_code=ld_code from ledgermaster where ld_name=''Chandan Pharmacy(''+ltrim(@warehouse_id)+'')''
	if @cr_ledg_code is null
	begin
		insert into LedgerMaster(unit_id,code_value,code_category,type,ld_name) values(@shop_code,8,8,''A'',''Chandan Pharmacy(''+ltrim(@warehouse_id)+'')'')
		select @cr_ledg_code=ld_code from ledgermaster where ld_name=''Chandan Pharmacy(''+ltrim(@warehouse_id)+'')''
	end
	select @dr_ledg_code=ld_code from ledgermaster where ld_name=''Stock Transfer''
	select @amount=sum(unit_pur_rate*qty) from rcpt_items where trf_id=@trf_id

	insert into vouchermaster (voucher_no,vch_type,vch_date,ledg_debit,ledg_credit,amount,narration,genfrom,unit_id,trf_flag,login_id)
	values( @voucher_no,''Jrnl'',@vch_date,@dr_ledg_code,@cr_ledg_code,@amount,''Vide Transfer Id No ''+ @trf_id,''Auto'',@shop_code,''N'',@operator)

	update rcpt_items set rcptok=''Y'' where trf_id=@trf_id
	select @result=''Posted Successfully.''
end
else
begin
	update rcpt_items set rcptok=''Y'' where trf_id=@trf_id
	select @result=''Already Posted or Posting Not Required.''
end
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGoods_Return]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE  PROCEDURE [dbo].[pGoods_Return]
@Master_gr_no varchar(16),
@gr_no varchar(16),
@master_key_id varchar(16),
@qty money,
@unit_id varchar(10),
@login_id varchar(10),
@result varchar(50) output
AS
set nocount on;
begin transaction
declare @confirm table(result varchar(16))
set @result=''Failed To Insert.''
if not exists(select gr_no from goodsreturn where gr_no=@gr_no and master_key_id=@master_key_id)
begin
	insert into GoodsReturn  
	(master_key_id,Master_gr_no,gr_no,qty,unit_id) 
	output inserted.master_key_id into @confirm
	values (@master_key_id,@Master_gr_no,@gr_no,@qty,@unit_id) 

	if(select count(result) from @confirm)>0
	begin
		insert into stocksTransInfo(unit_id,tran_type,trf_id,trf_from,trf_to,master_key_id,qty)
		values(@unit_id,''G'',@gr_no,@unit_id,@unit_id,@master_key_id,@qty)
		update stocks set quantity=quantity-@qty 
		where  master_key_id=@master_key_id and unit_id=@unit_id  and quantity>=@qty
	end
end
else if not exists(select master_key_id from stocksTransInfo where trf_id=@gr_no and master_key_id=@master_key_id)
begin
	insert into stocksTransInfo(unit_id,tran_type,trf_id,trf_from,trf_to,master_key_id,qty)
	values(@unit_id,''G'',@gr_no,@unit_id,@unit_id,@master_key_id,@qty)
	update stocks set quantity=quantity-@qty 
	where  master_key_id=@master_key_id and unit_id=@unit_id  and quantity>=@qty
end
if @@error=0
begin
	commit
	set @result=''Successfully Inserted.''
end
else
rollback transaction
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pPurchase_ReturnQueries]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[pPurchase_ReturnQueries]
@unit_id varchar(10),
@logic varchar(20),
@ld_code varchar(16), --Vendor Ledger Code
@item_id varchar(10),
@master_key_id varchar(16),
@prm_1 varchar(20),
@prm_2 varchar(20)
as
set nocount on;
if(@logic=''PR:Info'')
begin
	SELECT im.Item_Name,pr.auto_id, pr.master_key_id, pr.ld_code, 
	pr.ld_name, pr.quantity, 
	pr.packs, mki.Pack_Type, mki.Pack_Qty, mki.Batch_No, 
	mki.Exp_Date, (mki.npr/mki.pack_qty) upr
	FROM  dbo.Item_Master im 
	INNER JOIN dbo.Stocks stk ON im.Item_id = stk.Item_id 
	inner join masterkey_info mki on stk.master_key_id=mki.master_key_id 
	INNER JOIN dbo.purchase_return pr ON stk.master_key_id = pr.master_key_id   
	order by pr.auto_id desc;
	select distinct ld_code,ld_name from  dbo.purchase_return order by ld_name 
end
else if(@logic=''PR:Info By Group'')
begin
	SELECT im.Item_Name,pr.auto_id, pr.master_key_id, pr.ld_code, 
	pr.ld_name, pr.quantity, 
	pr.packs, mki.Pack_Type, mki.Pack_Qty, mki.Batch_No, 
	mki.Exp_Date, (mki.npr/mki.pack_qty) upr
	FROM  dbo.Item_Master im 
	INNER JOIN dbo.Stocks stk ON im.Item_id = stk.Item_id 
	inner join masterkey_info mki on stk.master_key_id=mki.master_key_id 
	INNER JOIN dbo.purchase_return pr ON stk.master_key_id = pr.master_key_id   
	order by pr.auto_id desc;
	select distinct ld_code,ld_name from  dbo.purchase_return order by ld_name 
end
else if(@logic=''PR:RecordByVendor'')
begin
	SELECT im.Item_Name,pr.auto_id, pr.master_key_id, pr.ld_code, 
	pr.ld_name, pr.quantity, 
	pr.packs, mki.Pack_Type, mki.Pack_Qty, mki.Batch_No, 
	mki.Exp_Date, (mki.npr/mki.pack_qty) upr
	FROM  dbo.Item_Master im 
	INNER JOIN dbo.Stocks stk ON im.Item_id = stk.Item_id 
	inner join masterkey_info mki on stk.master_key_id=mki.master_key_id 
	INNER JOIN dbo.purchase_return pr ON stk.master_key_id = pr.master_key_id   
	where pr.ld_code=@ld_code and pr.trf_flag=''N'' and pr.unit_id=@unit_id
	order by pr.auto_id desc;
end
else if(@logic=''PR:TransferInfo'')
begin
	select auto_id, item_id, master_key_id, quantity 
	from purchase_return 
	where ld_code=@ld_code and unit_id=@unit_id and trf_flag=''N''
end
else if(@logic=''PR:GR slip'')
begin
	select ti.trf_id gr_no,im.item_id,mki.master_key_id,im.item_name,mki.batch_no,mki.exp_date,
	mki.pack_type,mki.pack_qty,mki.mrp,(mki.npr/mki.pack_qty) upr,ti.qty ,im.shelf_no
	from trf_items ti
	inner join item_master im on ti.item_id=im.item_id 
	inner join masterkey_info mki on ti.master_key_id=mki.master_key_id
	where trf_id=@prm_1;
end
else if(@logic=''PR:InfoToTransfer'')
begin
	select master_key_id,convert(varchar(10),trf_date,111) trf_date, trf_from, trf_to, item_id, qty, trf_id
	from dbo.trf_items where trf_id=@prm_1
end
else if(@logic=''PR:DeleteRecord'')
begin
	delete from purchase_return where auto_id =@prm_1;
	select distinct ld_code,ld_name from  dbo.purchase_return 
	order by ld_name;
end
--select * from trf_master order by trf_date desc

--delete from trf_items where trf_id=''003300001/12-13''
--select * from stocks where master_key_id=''033002541171112''
--update stocks set quantity=quantity+10 where master_key_id=''033002541171112''' 
END
GO
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Md_UpdTrfMaster]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE  PROCEDURE [dbo].[Md_UpdTrfMaster]
@trfno varchar(16)=null,
@fromstore varchar(10)=null,
@tostore varchar(10)=null,
@user varchar(10)
AS

declare @no_item int

select @no_item=count(trf_id) from trf_items where trf_id=@trfno
if not exists(select * from trf_master where trf_id=@trfno)
begin
	insert into trf_master values (@trfno,@fromstore,@tostore,getdate(),@no_item,@user,''-'')
end
else
begin
	update trf_master set no_of_item=@no_item where trf_id=@trfno
end
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pDel_RecordFromTransferId]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pDel_RecordFromTransferId] 
@trf_id varchar(16),
@master_key_id varchar(16)=null,
@result varchar(16) output
AS
set nocount on;
--Delete Item from Transfer
if not exists(select * from trf_items where trf_id=@trf_id and master_key_id=@master_key_id  and lock_flag=1)
begin
	declare @qty int
	set @qty=0
	select @qty=qty from trf_items where trf_id=@trf_id and master_key_id=@master_key_id 
	
	delete from trf_items where trf_id=@trf_id and master_key_id=@master_key_id;
	update stocks set quantity=quantity+@qty where master_key_id=@master_key_id;
	delete from trf_master where no_of_item=0 and trf_id=@trf_id;
	set @result=''Successfully'';
end
else if exists(select trf_id from trf_items where trf_id=@trf_id and master_key_id=@master_key_id  and lock_flag=1)
begin
	set @result=''Locked''
end
else if not exists(select trf_id from trf_items where trf_id=@trf_id and master_key_id=@master_key_id  )
begin
	set @result=''Not Available''
end

update trf_master set no_of_item=x.noofitem from (select count(master_key_id) noofitem from trf_items where trf_id=@trf_id) x
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pStocksTransSelectQueries]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--pStocksTransSelectQueries ''MS-00033'',''U03302772/10-11'',''TransferId_Info'',''n/a'',''n/a'',''n/a''
CREATE Procedure [dbo].[pStocksTransSelectQueries]
@unit_id varchar(10),
@trf_id varchar(16),
@logic varchar(50),
@prm_1 varchar(50),
@prm_2 varchar(50),
@prm_3 varchar(50)
as
set nocount on;
if(@logic=''TransferId_Info'')
begin
	select ROW_NUMBER() OVER(ORDER BY rec_id DESC) rno, lock_flag,master_key_id,item_name,batch_no,exp_date,pack_type,pack_qty,upr,qty,(upr*qty) total ,trf_to
	from (
		select ti.rec_id,ti.lock_flag,ti.trf_to,ti.master_key_id,im.item_name,mki.batch_no,mki.exp_date,mki.pack_type,mki.pack_qty,(mki.npr/mki.pack_qty)upr,ti.qty 
		from trf_items ti 
		inner join masterkey_info mki on ti.master_key_id=mki.master_key_id and ti.item_id=mki.item_id
		inner join item_master im on mki.item_id=im.item_id 
		where ti.trf_id=@trf_id
	) trf_info
end
else if(@logic=''TransferId_InfoByShelfNo'')
begin
	select tr.item_id,trf_date,im.item_name,isnull(batch_no,''-'') batch_no,isnull(exp_date,''1900-01-01'') exp_date,
	qty,im.shelf_no,mrp, upr from  item_master im 
	inner join trf_items tr on im.item_id=tr.item_id
	inner join masterkey_info mki on tr.master_key_id=mki.master_key_id
	where trf_id=@trf_id 
	order by shelf_no,im.item_name
end
else if(@logic=''Form T-01'')
begin
	select item_id,lock_flag,master_key_id,item_name,batch_no,exp_date,pack_type,pack_qty,''-'' shelf_no,upr,qty,(upr*qty) total
	from (
		select im.item_id,ti.lock_flag,ti.trf_to,ti.master_key_id,im.item_name,mki.batch_no,isnull(mki.exp_date,''1900-01-01'') exp_date,
		mki.pack_type,mki.pack_qty,im.shelf_no,(mki.npr/mki.pack_qty) upr,ti.qty 
		from trf_items ti 
		inner join masterkey_info mki on ti.master_key_id=mki.master_key_id and ti.item_id=mki.item_id
		inner join item_master im on mki.item_id=im.item_id 
		where ti.trf_id=@trf_id
	) trf_info
	order by item_name
end
else if(@logic=''InternalSheet'')
begin
	select item_id,lock_flag,master_key_id,item_name,batch_no,exp_date,pack_type,pack_qty,shelf_no,upr,qty,(upr*qty) total
	from (
		select im.item_id,ti.lock_flag,ti.trf_to,ti.master_key_id,im.item_name,mki.batch_no,isnull(mki.exp_date,''1900-01-01'') exp_date,
		mki.pack_type,mki.pack_qty,im.shelf_no,(mki.npr/mki.pack_qty) upr,ti.qty 
		from trf_items ti 
		inner join masterkey_info mki on ti.master_key_id=mki.master_key_id and ti.item_id=mki.item_id
		inner join item_master im on mki.item_id=im.item_id 
		where ti.trf_id=@trf_id
	) trf_info
	order by item_name
end
else if(@logic=''UnitLedgerName'')
begin
	select trf_to,ld_name,count(master_key_id) num from trf_items ti 
	inner join ledgermaster lm on lm.ld_name like ''%''+trf_to+''%'' 
	where trf_id=@trf_id and lock_flag=0 group by trf_to,ld_name
end
else if(@logic=''Reconcile:ShelfNo'')
begin
select distinct isnull(Shelf_No,''N/A'') as shelf_no,isnull(Shelf_No,''N/A'') as shelf from item_master im 
inner join stocks st on im.item_id=st.item_id and st.unit_id=@unit_id order by shelf_no
end
else if(@logic=''Reconcile:ShelfNo'')
begin
select distinct isnull(Shelf_No,''N/A'') as shelf_no,isnull(Shelf_No,''N/A'') as shelf from item_master im 
inner join stocks st on im.item_id=st.item_id and st.unit_id=@unit_id order by shelf_no
end
else if(@logic=''InfoToTransfer'')
begin
	select master_key_id,convert(varchar(10),trf_date,111) trf_date, trf_from, trf_to, item_id, qty, trf_id
	from dbo.trf_items where trf_id=@trf_id
end
else if(@logic=''CloseTransferId'')
begin
	update trf_master set lock_flag=1 where trf_id=@trf_id;
	select ''Successfully Updated.'' Result
end
else if(@logic=''UnClosedTransferId'')
begin
	select trf_id,trf_to from trf_master 
	where trf_from!=trf_to and lock_flag=0
	and trf_from=@unit_id
	order by trf_id
end
else if(@logic=''TransferId_Locking'')
begin
	update trf_master set lock_flag=1 where trf_id=@trf_id;
	update trf_items set lock_flag=1 where trf_id=@trf_id;
	select ''Successfully Closed.''

end
--Extra Product Process
else if(@logic=''stocksByMasterKeyId'')
begin
	select  CAST((st.Quantity  / mki.Pack_Qty) AS integer) packs ,st.master_key_id,mki.pack_qty 
	from stocks st 
	inner join masterkey_info mki on st.master_key_id=mki.master_key_id and  st.item_id=mki.item_id
	where CAST((st.Quantity  / mki.Pack_Qty) AS integer) >0
	and unit_id=@unit_id
end
else if(@logic=''ExtraMatchMisMatch'')
begin
	SELECT     temp.master_key_id, temp.item_id, im.Item_Name, im.Shelf_No, temp.qty, mki.Pack_Type, mki.Pack_Qty
	FROM         dbo.TempExtraProduct AS temp 
	INNER JOIN  dbo.Item_Master im ON im.Item_id = temp.item_id 
	INNER JOIN dbo.Stocks st ON temp.master_key_id = st.master_key_id and st.unit_id=@unit_id
	inner join masterkey_info mki on st.master_key_id=mki.master_key_id and  st.item_id=mki.item_id
	WHERE     (temp.match_flag = @prm_1) and st.unit_id=@unit_id
end
else if(@logic=''Extra:UpdateMasterKeyId'')
begin
     update TempExtraProduct set trf_flag=''Y'' where item_id=@prm_1 and master_key_id=@prm_2 and unit_id=@unit_id;
     	select ''Successfully Updated.'' Result
end
 



--select * from trf_items where trf_id=''U03302772/10-11''
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsertRcptItemsMismatch]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pInsertRcptItemsMismatch]
@rec_id bigint,@master_key_id varchar(16),@trf_id varchar(20),
@trf_from varchar(10),@trf_to varchar(10),
@Item_id varchar(10),@item_name varchar(35),@Pack_Type varchar(10),@Pack_Qty int,
@rol int,@Batch_No varchar(20),@Exp_Date datetime,@PTR money,@NPR money,@MRP money,
@TaxId int,@unit_tax_cst money,@unit_tax_uptt money,@unit_tax_updt money,@unit_pur_rate money,@unit_sale_rate money,
@Qty int,@mfd_id varchar(10),@mfd_name varchar(50),@CreatedBy varchar(15)
AS
set nocount on;
INSERT INTO rcpt_itemsMismatch (rec_id,master_key_id,trf_id,trf_from,trf_to,Item_id,item_name,Pack_Type,Pack_Qty,rol,Batch_No,Exp_Date,PTR,NPR,MRP,TaxId,unit_tax_cst,unit_tax_uptt,unit_tax_updt,unit_pur_rate,unit_sale_rate,Qty,mfd_id,mfd_name,CreatedBy) 
values(@rec_id,@master_key_id,@trf_id,@trf_from,@trf_to,@Item_id,@item_name,@Pack_Type,@Pack_Qty,@rol,@Batch_No,@Exp_Date,@PTR,@NPR,@MRP,@TaxId,@unit_tax_cst,
	@unit_tax_uptt,@unit_tax_updt,@unit_pur_rate,@unit_sale_rate,@Qty,@mfd_id,@mfd_name,@CreatedBy)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pCurrentStockValue]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--[dbo].[pCurrentStockValue] ''MS-00033''
CREATE PROCEDURE [dbo].[pCurrentStockValue] 
	@unit_id varchar(10) 
AS
SET NOCOUNT ON;
BEGIN
	SELECT    isnull(im.shelf_no,''N/A'') shelf_no , im.Item_id, im.Item_Name, mki.Pack_Type, mki.Pack_Qty, mki.Batch_No, mki.Exp_Date, 
						  mki.MRP, mki.NPR, (mki.mrp/mki.pack_qty) unit_sale_rate,(mki.npr/mki.pack_qty) unit_pur_rate, 
	st.Quantity, isnull(sc.Quantity,0) AS sQty,((mki.npr/mki.pack_qty)*st.Quantity) StkValue
	FROM         dbo.stocks st 
	INNER JOIN dbo.Item_Master im ON st.Item_id = im.Item_id 
	LEFT OUTER JOIN  dbo.stock_check sc ON st.master_key_id = sc.master_key_id
	inner join masterkey_info mki on mki.master_key_id=st.master_key_id and mki.item_id=st.item_id 
	WHERE     (st.Quantity != 0) Order by im.shelf_no,im.item_name ;
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pShortExpiryList]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--pShortExpiryList ''MS-00033'',33
CREATE Procedure [dbo].[pShortExpiryList]
@unit_id varchar(10),
@days varchar(3)
 AS
set nocount on ;
SELECT st.Item_id, im.Item_Name,  mki.Pack_Type, Quantity, 
    mki.Batch_No, mki.Exp_Date, im.Shelf_No, DATEDIFF(day, GETDATE(), mki.Exp_Date) AS dys
FROM (select stocks.item_id,stocks.master_key_id,sum(quantity) quantity from stocks 
inner join masterkey_info mki on mki.master_key_id=stocks.master_key_id and mki.item_id=stocks.item_id  
WHERE unit_id = @unit_id and (mki.Exp_Date is not null AND  mki.Exp_Date!=''1900/01/01'')
group by stocks.item_id,stocks.master_key_id
) st INNER JOIN dbo.Item_Master im ON st.Item_id = im.Item_id
inner join masterkey_info mki on mki.master_key_id=st.master_key_id and mki.item_id=st.item_id 
where (DATEDIFF(day, GETDATE(), mki.Exp_Date) <= @days) and Quantity>0
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetBatchNos]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- [dbo].[pGetBatchNos] ''CP16664'',''MS-00003'',0
CREATE  PROCEDURE [dbo].[pGetBatchNos] 
@unit_id varchar(10),
@item_id varchar(7),
@Result varchar(10)=''Sales'' output
AS
SET NOCOUNT ON;
if(@result=''Sales'')
begin
	select ''1'' LogicNo,mki.master_key_id,mki.batch_no ,mki.exp_date ,quantity as qty ,mki.tax_id,mki.mrp,mki.pack_type,mki.pack_qty,
	mki.tax_rate,(mki.mrp/mki.pack_qty) usr  from stocks
	inner join masterkey_info mki on stocks.master_key_id=mki.master_key_id and stocks.unit_id=@unit_id
	where mki.item_id=@item_id and stocks.quantity>0  and (datediff(month,getdate(),mki.exp_date)>=1 OR mki.exp_date=''1900-01-01'')
	union
	select ''2'' LogicNo,mki.master_key_id,mki.batch_no ,mki.exp_date ,quantity as qty ,mki.tax_id,mki.mrp,mki.pack_type,mki.pack_qty,
	mki.tax_rate,(mki.mrp/mki.pack_qty) usr   from stocks
	inner join masterkey_info mki on stocks.master_key_id=mki.master_key_id  and stocks.unit_id=@unit_id
	where mki.item_id=@item_id and stocks.quantity=0  and (datediff(month,getdate(),mki.exp_date)>=1 OR mki.exp_date=''1900-01-01'')
	order by LogicNo,mki.exp_date 
end
else
if(@result=''StkTrf'')
begin
	select ''1'' LogicNo,mki.master_key_id,mki.batch_no ,mki.exp_date ,quantity as qty ,mki.tax_id,mki.mrp,mki.pack_type,mki.pack_qty,
	mki.tax_rate,(mki.mrp/mki.pack_qty) usr,(mki.npr/mki.pack_qty) upr,mki.npr  from stocks
	inner join masterkey_info mki on stocks.master_key_id=mki.master_key_id and stocks.unit_id=@unit_id
	where mki.item_id=@item_id and stocks.quantity>0 -- and (datediff(month,getdate(),mki.exp_date)>=1 OR mki.exp_date=''1900-01-01'')
end
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pTransferMismatchRecords]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--Pankaj Singh
CREATE proc [dbo].[pTransferMismatchRecords]
@unit_id varchar(10)
as
SELECT  @unit_id,   
dbo.stock_check.master_key_id,  isnull(dbo.stocks.Quantity,0) AS u_qty,isnull(stock_check.Quantity,0) AS w_qty,
case 
when isnull(dbo.Stocks.Quantity,0)>dbo.stock_check.Quantity then ''Local Qty Higher''
when isnull(dbo.Stocks.Quantity,0)<dbo.stock_check.Quantity then ''Server Qty Higher''
end as reason,getdate() cr_date,''N'' Status 
FROM         dbo.Stocks inner JOIN 
dbo.stock_check ON dbo.Stocks.master_key_id = dbo.stock_check.master_key_id AND dbo.Stocks.Quantity <> dbo.stock_check.Quantity
and  dbo.Stocks.unit_id=@unit_id  
union
SELECT   @unit_id,dbo.stocks.master_key_id, isnull(dbo.stocks.Quantity,0) AS u_qty,0 as w_qty,''Local Qty Higher'' as reason, 
getdate() cr_date,''N'' status from stocks where   unit_id=@unit_id and  quantity>0 and master_key_id not in(select master_key_id from stock_check where unit_id=@unit_id)
union
SELECT    @unit_id,dbo.stock_check.master_key_id, 0 AS u_qty,quantity as w_qty,''Server Qty Higher'' as reason,
getdate() cr_date,''N'' status from stock_check  where  unit_id=@unit_id and master_key_id not in(select master_key_id from stocks  where unit_id=@unit_id)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pDeleteTempWHSTOCK]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[pDeleteTempWHSTOCK]
@unit_id varchar(10)
AS 
set nocount on;
IF NOT EXISTS(SELECT * FROM sysobjects WHERE name=''stock_check'' AND xtype=''u'')
BEGIN    
     CREATE TABLE [dbo].[stock_check](
     unit_id varchar(10),
     item_id varchar(7), 
	 [master_key_id] [varchar](16) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL CONSTRAINT [DF_stock_check_master_key_id]  DEFAULT (''-''),
     [Quantity] [int] NOT NULL CONSTRAINT [DF_stock_check_qty]  DEFAULT ((0))
     )ON [PRIMARY]
END
else
 BEGIN
     DELETE FROM stock_check where unit_id=@unit_id;
 END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CorpVoucherUpdate]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[CorpVoucherUpdate] 
as
set nocount on;
declare @voucher_no varchar(16),@sale_inv_no varchar(15),@total money,@discount money
declare c1 cursor for
select sale_inv_no,round(total,0) total,round(total,0)-net discount from sale_master --where sale_inv_no=''014000002/09-10''
open c1
fetch next from c1 into @sale_inv_no,@total,@discount
while @@fetch_status=0
begin
update vouchermaster set amount=@total  where narration like ''%''+@sale_inv_no+''%'' and ledg_credit=12 --SALES A/C
update vouchermaster set amount=@discount  where narration like ''%''+@sale_inv_no+''%'' and ledg_debit=13   -- DISCOUNT ON SALES

fetch next from c1 into @sale_inv_no,@total,@discount
end
close c1
deallocate c1
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pCorpAutoSale]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Vijay Singh
-- Create date: 25-12-2009
-- Description:	Auto Sales of Corporate
-- =============================================
create PROCEDURE [dbo].[pCorpAutoSale] 
@Lot_No varchar(10)
AS
BEGIN
SET NOCOUNT ON;
declare @item_id varchar(7),@stockqty int,@BalQty int,@Sale_Qty int,@saleqty int,@master_key_id varchar(16),@quantity int,@temp_id varchar(7),
		@soldQty int,@sale_inv_no varchar(16),@counter int,@result varchar(16),@received money,@inv_date datetime
set @counter=0
set @soldqty=0

declare corpsale cursor for 
	select x.item_id,master_key_id,quantity,sale_qty from 
	(select item_id, (stk_qty-bal_qty) sale_qty from CorpAuditBal where status=''N'' and lot_no=@Lot_No
	) x inner join stocks on stocks.item_id=x.item_id  and quantity>0 and sale_qty>0 order by x.item_id
set @temp_id=''CORPXXX''
set @sale_qty=0
	
open corpsale
fetch next from corpsale into @item_id,@master_key_id,@quantity,@saleqty
while @@fetch_status=0
begin

			if @counter>10
			begin
				select @received=sv from sale_master where sale_inv_no=@sale_inv_no
				set @inv_date=convert(varchar(10),getDate(),111)
                exec SalesInvPosting @inv_date,@sale_inv_no,''CGHS Aliganj'',''CORP0004'',''Corp'',''CGHS Aliganj'',@received,''MS-00014'',''Credit'',''N/A'',''N'',''Auto Posting''
				set @counter=0
			end
			if @counter=0
			set @result=''Auto Generate''
			else
			set @result=@sale_inv_no
	
		--Logic
			if(@temp_id!=@item_id)
			begin	
				set @sale_qty=@saleqty
				set @temp_id=@item_id
				set @soldqty=0
		end
			if @sale_qty>=@Quantity
			begin
				exec pCGHS_InsSale ''CORP0004'',''CGHS Aliganj'',''CGHS Aliganj'',11.1,'''',@master_key_id,@item_id,@quantity,@quantity,''Credit'',''AutoSale'',
				''MS-00014'',''N'',0,0,0,0,''N/A'',@sale_inv_no=@result output
				set @sale_qty=@sale_qty-@quantity
				set @soldQty=@soldQty+@quantity
				set @counter=@counter+1
				set @sale_inv_no=@result
			end		
			else if @quantity>=@sale_qty and @sale_qty>0
			begin
				exec pCGHS_InsSale ''CORP0004'',''CGHS Aliganj'',''CGHS Aliganj'',11.1,''N/A'',@master_key_id,@item_id,@sale_qty,@sale_qty,''Credit'',''AutoSale1'',
				''MS-00014'',''N/A'',0,0,0,0,''N/A'',@sale_inv_no=@result output
       			set @soldQty=@soldQty+@sale_qty
				set @sale_qty=0
				set @counter=@counter+1
				set @sale_inv_no=@result
			end
				update CorpAuditBal set status=''Y'',sold_qty=@soldQty where item_id=@item_id and lot_no=@lot_no
		fetch next from corpsale into @item_id,@master_key_id,@quantity,@saleqty
end
close corpsale
deallocate corpsale

END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pLockSynchedRecord]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--pLockSynchedRecord ''033000519/12-13'',''-'',''MS-00033'',''SM'',''-'' 
CREATE procedure [dbo].[pLockSynchedRecord]
@sale_inv_no varchar(16),
@masterkey_id varchar(16),
@unit_id varchar(10),
@Logic varchar(10)
As
set nocount on;
IF(@Logic=''SM'')
   UPDATE  sale_master SET [trf_flag]=''Y'' WHERE sale_inv_no=@sale_inv_no and unit_id=@unit_id;
ELSE IF(@Logic=''SI'')
   UPDATE  sale_Items  SET [trf_flag]=''Y'' WHERE sale_inv_no=@sale_inv_no and master_key_id=@masterkey_id and unit_id=@unit_id;
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetDataToSyncCentral]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--pGetRevisionInfo ''MS-00033''
CREATE Procedure [dbo].[pGetDataToSyncCentral]
@unit_id varchar(10),
@Logic varchar(20)
as
set nocount on;
declare @sm_no int,@si_no int,@PreviousDate varchar(10),@Sync_flag char(1)
set @PreviousDate=convert(varchar,getDate()-1,111)
IF(@Logic=''ValidateNewRec'')
BEGIN
   select  @sm_no=count(sale_inv_no) from sale_master  where [trf_flag]=''N''  and unit_id=@unit_id
   select  @si_no=count(sale_inv_no) from sale_items   where [trf_flag]=''N''  and unit_id=@unit_id
   set @Sync_flag=''N''
   if((@sm_no+@si_no)>0)
	set @Sync_flag=''Y''
   select @Sync_flag as sync_flag
END
ELSE IF(@Logic=''NewRecords'')
BEGIN
  --Sale Master
  SELECT   TOP (1) Unit_id, Sale_Inv_No, Sale_Date, RefBy, Ref_Name, pt_name, total, discount, net, roundoff, Received, sv, pv, op_margin, tax_state, TaxableMed, 
           tax_med,TaxableFood, tax_food, total_tax, Paid_Tax, Tax_Realize, trf_flag, lock_flag, Pay_Mode, Card_no, hd_Flag, rcmOrderNo,credit_card_no,login_id
  FROM     Sale_Master where unit_id=@unit_id AND trf_flag=''N'';
  --Sale Items
  SELECT   TOP (1) unit_id, Master_key_id, Sale_Inv_No, Sale_Date, Item_id, Tax_Id, tax_rate, SR, dis_per, Sale_qty, SV, PV, Amount, taxValue, login_id, trf_flag
  FROM     Sale_Items where  unit_id=@unit_id AND trf_flag=''N'';

END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pCheckRecordToSync]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--pGetRevisionInfo ''IDCD''
CREATE Procedure [dbo].[pCheckRecordToSync]
@unit_id varchar(10)--Master Unit_id
as
set nocount on;
declare @siRec int,@voucherNo int,@smRec int, @trfFlag varchar(1)
select  @voucherNo=count(*) from vouchermaster where trf_flag=''N'' and unit_id=@unit_id
select  @smRec=count(*) from sale_master where trf_flag=''N'' and  Unit_id=@unit_id
select  @siRec=count(*) from sale_items  where trf_flag=''N'' and  unit_id=@unit_id
set @trfFlag=''N''
if((@smRec+@siRec+@voucherNo)>0)
	set @trfFlag=''Y''
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetSaleInvNos]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--pGetSaleInvNos ''MS-00033'',''Posted'',''N/A''
CREATE Procedure [dbo].[pGetSaleInvNos]
(
@unit_id varchar(10),
@BillType varchar(20)=''N/A'',
@SearchString Varchar(16)
)
as
set nocount on;
if(@BillType=''Posted'' and @SearchString!=''N/A'')
	select top 20 sale_inv_no,pt_name,sale_date 
	from sale_master 
	where Pay_Mode in (''CA'',''CC'') and sale_inv_no like @SearchString+''%'' or pt_name like @SearchString+''%'' 
	order by sale_date desc;
else if (@BillType=''UnPosted'' and @SearchString!=''N/A'')
	select top 20 sale_inv_no,pt_name,sale_date 
	from t_sale_master 
	where sale_inv_no like @SearchString+''%'' or pt_name like @SearchString+''%'' 
else if (@BillType=''PostedCr'' and @SearchString!=''N/A'')
	select top 20 sale_inv_no,pt_name,sale_date 
	from sale_master 
	where Received=0 and sale_inv_no like @SearchString+''%'' or pt_name like @SearchString+''%'' 
else if (@BillType=''UnPostedCr'' and @SearchString!=''N/A'')
	select top 20 sale_inv_no,pt_name,sale_date 
	from t_Sale_Master 
	where Received=0 and sale_inv_no like @SearchString+''%'' or pt_name like @SearchString+''%'' 
else if(@BillType=''Posted'' )
	select top 20 sale_inv_no,pt_name,sale_date 
	from sale_master 
	where Pay_Mode in (''CA'',''CC'') 
	order by sale_date desc;
else if (@BillType=''UnPosted'' and @SearchString=''N/A'')
	select top 20 sale_inv_no,pt_name,sale_date 
	from t_sale_master 
	order by sale_date desc;
else if (@BillType=''PostedCr''  and @SearchString=''N/A'')
	select top 20 sale_inv_no,pt_name,sale_date 
	from sale_master 
	where Received=0
	order by sale_date desc;
else if (@BillType=''UnPostedCr''  and @SearchString=''N/A'')
	select top 20 sale_inv_no,pt_name,sale_date 
	from t_Sale_Master 
	where Received=0 
	order by sale_date desc;
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pSalesRegister]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--pSalesRegister ''MS-00033'',''2012/03/30'',''2012/03/30'',''ALL'',''ALL''
CREATE PROCEDURE [dbo].[pSalesRegister]
@unit_id varchar(10),
@f_date datetime,
@l_date datetime,
@sType varchar(10),
@login_id varchar(10)
 AS
 set nocount on;
IF @login_id=''ALL''
begin
	if @sType=''ALL''
	SELECT     TOP 100 PERCENT Sale_Date, Sale_Inv_No, pt_name,ref_name,total, roundoff, net, Received,(total-discount-received) balance, 
	case when pay_Mode=''CA'' then ''By Cash'' else case when pay_mode=''CC'' then ''By Credit Card'' else ''Credit Sales'' end end  Pay_Mode 
	FROM         dbo.Sale_Master
	WHERE unit_id=@unit_id and  (Convert(varchar(10),Sale_Date,111) BETWEEN  Convert(varchar(10),@f_date,111)  AND  Convert(varchar(10),@l_date,111))
	ORDER BY Sale_Inv_No
	if @sType=''SALES''
	SELECT     TOP 100 PERCENT Sale_Date, Sale_Inv_No, pt_name,ref_name,total, roundoff, net, Received,(total-discount-received) balance, 
	case when pay_Mode=''CA'' then ''By Cash'' else case when pay_mode=''CC'' then ''By Credit Card'' else ''Credit Sales'' end end  Pay_Mode 
	FROM         dbo.Sale_Master
	WHERE unit_id=@unit_id and    (Convert(varchar(10),Sale_Date,111) BETWEEN  Convert(varchar(10),@f_date,111)  AND  Convert(varchar(10),@l_date,111)) AND TOTAL>0
	ORDER BY Sale_Inv_No
	if @sType=''RETURN''
	SELECT     TOP 100 PERCENT Sale_Date, Sale_Inv_No, pt_name,ref_name,total, roundoff, net, Received, (total-discount-received) balance,
	case when pay_Mode=''CA'' then ''By Cash'' else case when pay_mode=''CC'' then ''By Credit Card'' else ''Credit Sales'' end end  Pay_Mode 
	FROM         dbo.Sale_Master
	WHERE  unit_id=@unit_id and   (Convert(varchar(10),Sale_Date,111) BETWEEN  Convert(varchar(10),@f_date,111)  AND  Convert(varchar(10),@l_date,111)) AND TOTAL<0
	ORDER BY Sale_Inv_No
end
else
BEGIN

	if @sType=''ALL''
		SELECT     TOP 100 PERCENT Sale_Date, Sale_Inv_No, pt_name,ref_name,total, roundoff, net, Received, (total-discount-received) balance,
		case when pay_Mode=''CA'' then ''By Cash'' else case when pay_mode=''CC'' then ''By Credit Card'' else ''Credit Sales'' end end  Pay_Mode 
		FROM         dbo.Sale_Master
		WHERE   unit_id=@unit_id and login_id=@login_id and   (Sale_Date BETWEEN  @f_date  AND  @l_date) 
		ORDER BY Sale_Inv_No
	if @sType=''SALES''
		SELECT     TOP 100 PERCENT Sale_Date, Sale_Inv_No, pt_name,ref_name,total, roundoff, net, Received, (total-discount-received) balance,
		case when pay_Mode=''CA'' then ''By Cash'' else case when pay_mode=''CC'' then ''By Credit Card'' else ''Credit Sales'' end end  Pay_Mode 
		FROM         dbo.Sale_Master
		WHERE   unit_id=@unit_id and  login_id=@login_id and (Sale_Date BETWEEN  @f_date  AND  @l_date) AND TOTAL>0
		ORDER BY Sale_Inv_No
	if @sType=''RETURN''
		SELECT   TOP 100 PERCENT Sale_Date, Sale_Inv_No, pt_name,ref_name,total, roundoff, net, Received,(total-discount-received) balance,
	  	case when pay_Mode=''CA'' then ''By Cash'' else case when pay_mode=''CC'' then ''By Credit Card'' else ''Credit Sales'' end end  Pay_Mode 
		FROM         dbo.Sale_Master
		WHERE   unit_id=@unit_id and   login_id=@login_id and (Sale_Date BETWEEN  @f_date  AND  @l_date) AND TOTAL<0
		ORDER BY Sale_Inv_No
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pAudit_GetDailySales]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' CREATE procedure [dbo].[pAudit_GetDailySales]
 @unit_id varchar(10),
 @sale_date datetime,
 @logic varchar(10)
 As
  if(@logic=''GetSales'')
   BEGIN
   select x.SMAMT,x.SMrecno,y.SIAMT,y.SIrecno from (
   select ''S'' TBL_NAME,isnull(sum(total),0)  SMAMT,isnull(count(sale_inv_no),0) SMrecno from sale_master  where unit_id=@unit_id and convert(varchar,sale_date,111)=convert(varchar,@sale_date,111)
   ) x inner join (
   select ''S'' TBL_NAME,isnull(sum(amount),0) SIAMT,isnull(count(sale_inv_no),0) SIrecno from sale_ITEMS   where unit_id=@unit_id and convert(varchar,sale_date,111)=convert(varchar,@sale_date,111)
   ) y on x.TBL_NAME=y.TBL_NAME
   END
 
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetDataToUpdateCentral]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' --Ajeet Kumar
 --05-03-2010
CREATE Procedure [dbo].[pGetDataToUpdateCentral] 
@login_id varchar(10),
@unit_id varchar(10),
@logic varchar(15)
as
set nocount on;
declare @Currentdate datetime
    set @Currentdate=getDate()
if @logic=''Sale_Master''
BEGIN
--Sale Master
SELECT  Unit_id, Sale_Inv_No, Sale_Date, RefBy, Ref_Name, pt_name, total, discount, net, roundoff, Received, sv, pv, op_margin, tax_state, TaxableMed, 
        tax_med, TaxableFood, tax_food, total_tax, Paid_Tax, Tax_Realize, trf_flag, lock_flag, Pay_Mode, Card_no, hd_Flag, rcmOrderNo, login_id, credit_card_no
FROM    Sale_Master where unit_id=@unit_id and trf_flag=''N''
END
else if @logic=''Sale_Items''
BEGIN
--Sale Items  
SELECT unit_id, Master_key_id, Sale_Inv_No, Sale_Date, Item_id, Tax_Id, tax_rate, SR, dis_per, Sale_qty, SV, PV, Amount, taxValue, login_id, trf_flag
FROM   Sale_Items where unit_id=@unit_id and trf_flag=''N''
END

' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pIsRecordExists]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- pIsRecordExists ''MS-00033'',''CheckSalesReturnEntry''
CREATE Procedure [dbo].[pIsRecordExists]
@unit_id varchar(10),
@logic varchar(50)=''N/A'',
@prm_1 varchar(50)=''N/A'',
@prm_2 varchar(50)=''N/A'',
@prm_3 varchar(50)=''N/A'',
@prm_Num int=0,
@result varchar(3)=''NO'' output
as
set nocount on;
set @result=''NO'';
if(@logic=''CheckSalesReturnEntry'')
begin
	
	if exists (select top 1 Master_key_id from sale_items where master_key_id=@prm_1 and sale_inv_no=@prm_2 and sale_qty>=abs(@prm_Num)  and unit_id=@unit_id)
		set @result=''YES'';
	else if (@prm_2=''Audit'')
	begin
		declare @qty int
		select @qty=sum(sale_qty) from sale_items where master_key_id=@prm_1 and unit_id=@unit_id;
		if(@qty>abs(@prm_Num))
				set @result=''YES'';
	end
	
end

' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsTempExtraProduct]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[pInsTempExtraProduct]
@unit_id varchar(10),
@item_id nvarchar(7),
@master_key_id varchar(16),
@qty int,
@match_flag char(1),
@trf_flag char(1),
@remark varchar(200),
@result varchar(20)=''N/A'' output
AS
set nocount on;
INSERT INTO [TempExtraProduct] 
( unit_id,item_id,master_key_id,qty,match_flag,trf_flag,remark)
VALUES
 (@unit_id,@item_id,@master_key_id,@qty,@match_flag,@trf_flag,@remark)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pCheckCorporateCard]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--pCheckCorporateCard ''AM000009'',''N/A''
CREATE Procedure [dbo].[pCheckCorporateCard]
(
@unit_id varchar(10),
@CorpCardNo varchar(20)=''N/A'',
@status varchar(15) output
)
as
set nocount on;
if exists(select Corp_Id from Corp_Cont_Info where Corp_id=@CorpCardNo and link_with_unit=@unit_id)
begin
select @status =case when c_to>getdate() then ''Active'' else ''Expired'' end 
from Corp_Cont_Info where Corp_Id= @CorpCardNo  and link_with_unit=@unit_id;
end
else
set @status=''Not Exists'';
--select  corp_id, contract_No, inst_name, address1, address2, city, state, discount, credit, pur_type, brief_Des, pay_type, c_From, c_To, Contact_Person, 
--                      contact_No, link_with_unit from Corp_Cont_Info where corp_id=''CORP0016''
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pPurchaseQueries]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[pPurchaseQueries]
@unit_id varchar(10),
@purch_id varchar(16),
@master_key_id varchar(16),
@logic varchar(20),
@Seq_No BigInt,
@prm_1 varchar(20),
@prm_2 varchar(20),
@result varchar(20) output 
as
set nocount on;
if(@logic=''Purch_Master'')
begin
	select purch_id,inv_date,bill_date,inv_no,inv_total,inv_discount,netamount,decpart,roundoff,inv_tax,inv_type 
	from purch_master 
	where purch_id=@purch_id;
end
else if(@logic=''Purch_Items'')
begin
	select Seq_No auto_id,item_id,item_name,pack_type,pack_qty,barcode_no,batch_no,exp_date,trade,mrp,
	it_free,qty,tax_id taxid,disper,amount,status_flag 
	from purch_items 
	where purch_id=@purch_id 
	order by Seq_no desc
end
else if(@logic=''DeletePurchMaster'')
begin
	delete purch_master where purch_id=@purch_id;
end
else if(@logic=''DeletePurchItems'')
begin
	delete purch_items where Seq_No=@Seq_No and purch_id=@purch_id;
end
else if(@logic=''DeletePurchaseId'')
begin
	delete from purch_items where  purch_id=@purch_id;
	delete from purch_master where  purch_id=@purch_id;
end
else if(@logic=''PurchBillInfo'')
begin
		--Product Information
		select Seq_No auto_id ,item_id,item_name,batch_no,pack_type,pack_qty,barcode_no,batch_no,exp_date,trade,mrp
		,it_free,qty,tax_id,disper,amount,status_flag  from purch_items
		where  purch_id=@purch_id 
		order by Seq_No desc


		--Invoice Information
		select ''Allow'' result, purch_id,bill_date,inv_date,inv_no,inv_total 
		,inv_tax 
		,inv_discount 
		,netamount
		,decpart
		,roundoff ,inv_type 
		from Purch_Master where purch_id=@purch_id 
	end

 

' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsIntoPurchaseMaster]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[pInsIntoPurchaseMaster]
@purch_id		nVarChar(16),
@inv_date		datetime,
@bill_date		datetime,
@inv_no			nVarChar(15),
@inv_total		money,
@inv_discount	money,
@netamount		money,
@decpart		money,
@roundoff		money,
@inv_tax		money,
@inv_type		nVarchar(1),
@result varchar(15) output
as
set nocount on;
declare @confirm table(purch_id varchar(16));

INSERT INTO purch_master  (purch_id,inv_date,bill_date,inv_no,inv_total,inv_discount,netamount,decpart,roundoff,inv_tax,inv_type) 
output inserted.purch_id into @confirm 
VALUES (@purch_id,@inv_date,@bill_date,@inv_no,@inv_total,@inv_discount,@netamount,@decpart,@roundoff,@inv_tax,@inv_type)

if(select count(purch_id) from @confirm)>0
set @result=''Successfully Inserted.''
else
set @result=''Failed To Insert''
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsertPurchItems]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[pInsertPurchItems]
@purch_id varchar(16),
@Seq_No bigint,
@item_id varchar(10),
@item_name varchar(100),
@pack_type varchar(15),
@pack_qty int,
@barcode_no varchar(30),
@batch_no varchar(15),
@exp_date datetime,
@trade money,
@mrp money,
@it_free money,
@qty money,
@tax_id int,
@dis_per money,
@amount money,
@status_flag varchar(1),
@result varchar(20) output
as
set nocount on;
declare @confirm table(purch_id varchar(16));

if((select count(Seq_No) from purch_items where seq_no=@Seq_No)=0)
BEGIN
    INSERT INTO purch_items
    (Seq_No,item_id,item_name,pack_type,pack_qty,barcode_no,batch_no,exp_date,
    trade,mrp,it_free,qty,tax_id,disper,amount,purch_id,status_flag) 
    output inserted.purch_id into @confirm 
    VALUES(@Seq_No,@item_id,@item_name,@pack_type,@pack_qty,@barcode_no,@batch_no,@exp_date,
    @trade,@mrp,@it_free,@qty,@tax_id,@dis_per,@amount,@purch_id,@status_flag)
    if(select count(purch_id) from @confirm)>0
    set @result=''Successfully Inserted.''
    else
    set @result=''Failed To Insert''
END
else
    set @result=''Duplicate record''
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsertIntoRcptItems]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create Procedure [dbo].[pInsertIntoRcptItems] --''000087997/08-09'',''W00013457/08-09'',''2009-01-23'',''MS-00001'',''MS-00007'',''CP18305'',
--''CERELAC WHEAT RIF'',''General'',''5'',''400GM'',''1'',''2'',''82740451DB'',''2009-09-01'',''89.7000'',''100.9100'',''110.0000'',''10'',''0.0000'',''11.2125'',
--''0.0000'',''100.9100'',''110.0000'',''1'',''CM00146'',''NESTLE'',''1''
@master_key_id varchar(16),
@Trf_id varchar(16),
@trf_date datetime,
@Trf_From varchar(10),
@Trf_To varchar(10),
@item_id varchar(7),
@item_name varchar(50),
@gr_item varchar(10),
@discount int,
@pack_type varchar(10),
@pack_qty int,
@rol int,
@batch_no varchar(10),
@exp_date datetime,
@ptr money,
@npr money,
@mrp money,
@taxid int,
@unit_tax_cst money,
@unit_tax_uptt money, 
@unit_tax_updt money,
@unit_pur_rate money, 
@unit_sale_rate money,
@qty int,
@mfd_id varchar(10),
@mfd_name varchar(50),
@ho_shelfno varchar(15)
as
if (select count(*) from rcpt_items where trf_id=@trf_id and master_key_id=@master_key_id)=0
begin
insert into rcpt_items  (master_key_id, Trf_id, trf_date, Trf_From, Trf_To, item_id, 
item_name, gr_item, discount, pack_type, pack_qty, rol, batch_no, exp_date, ptr, npr,
  mrp, taxid, unit_tax_cst,unit_tax_uptt, unit_tax_updt, unit_pur_rate, unit_sale_rate,
qty, mfd_id, mfd_name, RcptQty, RcptOk, RcptTrf, ho_shelfno,createdby) 
 values(@master_key_id,@Trf_id,@Trf_date,@Trf_from,@Trf_to,@item_id,@item_name, @gr_item, @discount, @pack_type, @pack_qty, 0,
 @batch_no, @exp_date, @ptr, @npr,
  @mrp, @taxid, @unit_tax_cst,@unit_tax_uptt, @unit_tax_updt, @unit_pur_rate, @unit_sale_rate,
@qty, @mfd_id, @mfd_name, @qty, ''N'', ''N'', @ho_shelfno,''AUTO'')
   
end
--select * from rcpt_items where trf_id=''W00013457/08-09''
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pGetTransferId_Info]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- pGetTransferId_Info ''U03318437/11-12''
CREATE Procedure [dbo].[pGetTransferId_Info]
@transfer_id varchar(16)=''-''
as
set nocount on;
select im.item_id,mki.master_key_id,im.item_name,mki.batch_no,mki.exp_date,
mki.pack_type,mki.pack_qty,mki.mrp,(mki.npr/mki.pack_qty) upr,ri.qty ,im.shelf_no
from rcpt_items ri
inner join item_master im on ri.item_id=im.item_id 
inner join masterkey_info mki on ri.master_key_id=mki.master_key_id
where trf_id=@transfer_id;
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pMkCorrection]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[pMkCorrection]
@master_key_id varchar(16),
@batch_no varchar(10),
@exp_date varchar(10),
@mrp money=0,
@ptr money =0,
@npr money=0,
@upr money=0,
@usr money=0,
@tax int=0
as
set nocount on;
update masterkey_info set  batch_no=@batch_no ,exp_date=@exp_date,mrp=@mrp,ptr=@ptr,npr=@npr,upr=@upr,usr=@usr,tax_id=@tax
where master_key_id=@master_key_id

update Rcpt_items set batch_no=@batch_no,exp_date=@exp_date,mrp=@mrp,ptr=@ptr,npr=@npr,unit_pur_rate=@upr,unit_sale_rate=@usr,taxid=@tax
where master_key_id=@master_key_id
' 
END
GO
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsertTrfItemsMismatch]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[pInsertTrfItemsMismatch]
@rec_id bigint,
--@master_key_id varchar(16),
@trf_id varchar(20),
@trf_from varchar(10),
@trf_to varchar(10),
@Item_id varchar(10),
@item_name varchar(35),
@Pack_Type varchar(10),
@Pack_Qty int,
@rol int,
@Batch_No varchar(20),
@Exp_Date datetime,
@PTR money,
@NPR money,
@MRP money,
@TaxId int,
@unit_tax_cst money, 
@unit_tax_uptt money, 
@unit_tax_updt money,
@unit_pur_rate money,
@unit_sale_rate money,
@Qty int,
@mfd_id varchar(10),
@mfd_name varchar(50),
@CreatedBy varchar(15)
 AS



INSERT INTO trf_itemsMismatch (rec_id,trf_id,trf_from,trf_to,Item_id,item_name,Pack_Type,Pack_Qty,rol,Batch_No,Exp_Date,PTR,NPR,MRP,TaxId,unit_tax_cst,unit_tax_uptt,unit_tax_updt,unit_pur_rate,unit_sale_rate,Qty,mfd_id,mfd_name,CreatedBy) 
values(@rec_id,@trf_id,@trf_from,@trf_to,@Item_id,@item_name,@Pack_Type,@Pack_Qty,@rol,@Batch_No,@Exp_Date,@PTR,@NPR,@MRP,@TaxId,@unit_tax_cst,
	@unit_tax_uptt,@unit_tax_updt,@unit_pur_rate,@unit_sale_rate,@Qty,@mfd_id,@mfd_name,@CreatedBy)
' 
END
GO
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ins_Audit_Item]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Ins_Audit_Item]
@audit_date datetime,
@item_id varchar(10),
@phy_stock int,
@comp_stock int,
@remarks varchar(1000),
@audit_by varchar(50) 
AS

declare @item_name varchar(50)
declare @pack varchar(10)
declare @pack_qty int

select @item_name=item_name ,@pack=pack_type,@pack_qty=pack_qty from item_master where item_id=@item_id

if not exists(select * from audit_info where item_id=@item_id and audit_date=@audit_date)
begin
	insert into audit_info (audit_date,item_id,item_name,pack_size,pack_qty,phy_stock,comp_stock,remarks,audit_by)
	values(@audit_date,@item_id,@item_name,@pack,@pack_qty,@phy_stock,@comp_stock,@remarks,@audit_by)
end
else
begin
	update audit_info set phy_stock=@phy_stock,remarks=@remarks  where item_id=@item_id and audit_date=@audit_date
end
' 
END
GO
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pIns_Audit_Item]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create PROCEDURE [dbo].[pIns_Audit_Item]
@audit_date datetime,
@item_id varchar(10),
@phy_stock int,
@comp_stock int,
@remarks varchar(1000),
@audit_by varchar(50) 
AS

declare @item_name varchar(50)
declare @pack varchar(15)
declare @pack_qty int

select @item_name=item_name ,@pack=pack_type,@pack_qty=pack_qty from item_master where item_id=@item_id

if not exists(select item_id from audit_info where item_id=@item_id and audit_date=@audit_date)
begin
	insert into audit_info (audit_date,item_id,item_name,pack_size,pack_qty,phy_stock,comp_stock,remarks,audit_by)
	values(@audit_date,@item_id,@item_name,@pack,@pack_qty,@phy_stock,@comp_stock,@remarks,@audit_by)
end
else
begin
	update audit_info set phy_stock=@phy_stock,remarks=@remarks  where item_id=@item_id and audit_date=@audit_date
end
' 
END
GO
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ins_CardHistoryInfo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Ins_CardHistoryInfo]
@CardNo varchar(20)=null,
@SpouseName Varchar(30),
@SpouseDOB datetime,
@ChildName1 varchar(30),
@ChildDOB1 datetime,
@ChildName2 varchar(30),
@ChildDOB2 datetime,
@ChildName3 varchar(30),
@ChildDOB3 datetime,
@ChildName4 varchar(30),
@ChildDOB4 datetime,
@ChildName5 varchar(30),
@ChildDOB5 datetime,
@CardPrinted varchar(1)
as

INSERT INTO Card_History(Card_No, Spouse_Name,Spouse_DOB,Child_Name_1,Child_DOB_1,Child_Name_2,Child_DOB_2,Child_Name_3,Child_DOB_3,Child_Name_4,Child_DOB_4,Child_Name_5,Child_DOB_5,Card_Printed)
 values(@CardNo,@SpouseName,@SpouseDOB,@Childname1,@ChildDOB1,@Childname2,@ChildDOB2,@Childname3,@ChildDOB3,@Childname4,@ChildDOB4,@Childname5,@ChildDOB5,@CardPrinted)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pSingleMkInsertion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[pSingleMkInsertion]
@item_id varchar(10),
@master_key_id varchar(16),
@pack_type varchar(20),
@pack_qty int,
@batch_no varchar(10),
@exp_date varchar(10),
@mrp money=0,
@ptr money =0,
@npr money=0,
@upr money=0,
@usr money=0,
@tax_id int=0,
@tax_rate decimal,
@barcode_no varchar(16),
@result varchar(10) output
as
set nocount on;
  declare @confirm table(masterkey varchar(16))
  delete from masterkey_info where master_key_id=@master_key_id
  insert into masterkey_info(item_id, master_key_id, pack_type, pack_qty, mrp, npr, ptr, upr, usr, exp_date, batch_no, tax_id, barcode_no, tax_rate, upd_date)
  output inserted.master_key_id into @confirm
  values(@item_id,@master_key_id,@pack_type,@pack_qty,@mrp,@npr,@ptr,@upr,@usr,@exp_date,@batch_no,@tax_id,@barcode_no,@tax_rate,getDAte())
  if((select count(masterkey) from @confirm)>0)
     set @result=''Success''
  else
     set @result=''Not Saved''
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pStocksImportPosting]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--After Receiving Product Account Books Should Be updated
--Vijay Singh
--02-04-2009

--[dbo].[StocksImportPosting] ''W00000020/09-10'',''2009/04/02'',''MS-00006'',''MS-00001'',''Chandan Pharmacy-Head Office(MS-00001)'',238,''VIJAY'',''X''
CREATE PROCEDURE [dbo].[pStocksImportPosting] 
@trf_id varchar(15),
@trf_date datetime,
@unit_id varchar(10),   --To Whom Stock Transfered
@trf_from varchar(10),
@trfFromLedger varchar(80),
@amount money=0,
@login_id varchar(10),
@result varchar(100)=null  output
AS
set nocount on;
declare @dr_ledg_code int,
@voucher_no varchar(16),@cr_ledg_code varchar(16)

	if @trf_from=''MS-00001''
		set @trfFromLedger=''Chandan Pharmacy(MS-00001)''

if not exists (select unit_id from vouchermaster where unit_id=@unit_id and  narration like ''%''+ltrim(@trf_id)+''%'')	
update rcpt_items set rcptok=''N'' where trf_id=@trf_id
	
if  (select  count(trf_id)  from rcpt_items where rcpttrf=''Y'' and rcptok!=''Y''  and trf_id=@trf_id and trf_from!=@unit_id)>0
begin	
	select @cr_ledg_code=ld_code from ledgermaster where ld_name=@trfFromLedger
	if @cr_ledg_code is null
	begin
		insert into LedgerMaster(unit_id,code_value,code_category,type,ld_name) values(@unit_id,8,8,''A'',@trfFromLedger)
		select @cr_ledg_code=ld_code from ledgermaster where ld_name=@trfFromLedger
	end
	select @dr_ledg_code=ld_code from ledgermaster where ld_name=''Stock Transfer''
	select @voucher_no=dbo.fnCreateVoucherNo()
	update config set lastvoucherno=lastvoucherno+1
	
	insert into vouchermaster (voucher_no,vch_type,vch_date,ledg_debit,ledg_credit,amount,narration,genfrom,unit_id,trf_flag,login_id)
	values( @voucher_no,''Jrnl'',@trf_date,@dr_ledg_code,@cr_ledg_code,@amount,''Vide Transfer Id No ''+ @trf_id,''Auto'',@unit_id,''N'',@login_id)

	update rcpt_items set rcptok=''Y'' where trf_id=@trf_id
	select @result=''Posted Successfully.''
end
else
begin
	update rcpt_items set rcptok=''Y'' where trf_id=@trf_id
	select @result=''Already Posted or Posting Not Required.''
end
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsertSale]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

--[dbo].[pInsertSale] ''MS-00033'',''CP14408'',''033002590021112'',''AM000009'',1,''N/A'',''CHCL-00562'',''033042965/11-12'',0,0,0,0,''res''
CREATE Procedure [dbo].[pInsertSale] 
@unit_id varchar(10),
@item_id varchar(10),
@master_key_id varchar(16),
@card_no varchar(20),
@sold_qty int,
@old_sale_inv_no varchar(16)=''N/A'',
@login_id varchar(10),
@sale_inv_no varchar(16) output,
@total money output,
@discount money output,
@payable money output,
@roundoff money  output,
@result varchar(10) output --this is also use to recalculate the discount as Calculate or New
AS
begin transaction
set nocount on;
--Declaration of Variable
declare @cst_per float,@vat_per  float,@upr float,@usr float,@d_usr float,@stock_qty int,@sv money,@pv float,@amount float,
@item_group varchar(10),@pt_name varchar(35),@ref_by varchar(5),@ref_name varchar(35),
@nsv money,@TaxValue money,@nsr money,@dis_per money,@margin money,@mrp money,@tax_id int,@tax_rate money,@DiscountLogic varchar(10)
declare @confirm table(result varchar(16))
set @margin=0;set @tax_rate=0;set @dis_per=0;set @d_usr=0.00;
set @DiscountLogic=@result;set @pt_name=''N/A'';set @ref_by=''DST'';set @ref_name=''District Hospital''

--Calculate Unit Sale MRP after Discount
select @item_group=im.gr_item,@mrp=mki.mrp,@upr=isnull(mki.upr,0),@usr=isnull(mki.usr,0), @tax_id=mki.tax_id,@tax_rate=mki.tax_rate
from MasterKey_Info mki inner join Item_Master im on im.Item_id=mki.item_id where master_key_id=@master_key_id;

set @margin=((@usr-@upr)*100)/@usr;
--Initialize Tax Id,Item Group
execute pGetCurrentTaxRate @unit_id,@tax_id,@tax_rate output;
set @dis_per=0
if (len(@old_sale_inv_no)>4) 
begin
	if(@old_sale_inv_no!=''Audit'')
	select @dis_per=isnull((Amount-SV)*100/amount,0) from sale_items where master_key_id=@master_key_id and sale_inv_no=@old_sale_inv_no
	else if(@old_sale_inv_no=''Audit'')
	select top 1  @dis_per=isnull((Amount-SV)*100/amount,0) from sale_items where master_key_id=@master_key_id 
	
end
else
begin
	if  exists(select Card_No from card_info where card_no=@card_no and len(card_no)>=8 and left(@card_no,4)!=''CORP'')
	begin
	if(@unit_id!=''MS-00034'')
	BEGIN
		if @margin>10 and @margin<20
			set @dis_per=5
		else if @margin>=20 
			set @dis_per=10
	END
	end
	else if  exists(select corp_id from Corp_Cont_Info where corp_id=@card_no and c_to>getdate() and left(@card_no,4)=''CORP'')
	begin
		select @dis_per=discount,@ref_name=ltrim(inst_name)+'' [''+corp_id+'']'' from Corp_Cont_Info where corp_id=@card_no
		set @ref_by=''DST'';
	end
	ELSE IF(@unit_id=''MS-00034'') --Babu Banarsi Das Unit
	begin
		if @margin>=10 and @margin<20 and @item_group not in(''GENERAL'',''FOOD PDT'')
			set @dis_per=5
		if @margin>=20 and @item_group not in(''GENERAL'',''FOOD PDT'')
			set @dis_per=10
	end
	
end
--Calculate Discounted Unit_Sale_rate
begin
	set @amount=@sold_qty*@usr;
	set @d_usr=(@usr*(100-@dis_per))/100
	set @sv=@sold_qty*@d_usr
	set @pv=isnull((@upr*@sold_qty),0)
	set @nsr=@d_usr/(1+(@cst_per+@vat_per)/100)
	set @nsv=@nsr*@sold_qty
end
--Tax Calculation
set @TaxValue=@sv-((@sv*100)/(100+@tax_rate));

if @upr=0 
	set @upr=.001


if(@sale_inv_no=''Auto Generate'')
begin
	execute pGetNewInvoiceNo @unit_id,@sale_inv_no output
	set @pt_name=''Temp: ''+@sale_inv_no;
	insert into t_sale_master (sale_inv_no,sale_date,refby,ref_name,pt_name,total,discount,net,roundoff,received,sv,TaxableMed,TaxableFood,Unit_id,lock_flag,login_id,Card_no) 
	values(@sale_inv_no,convert(varchar(10),getdate(),111),@ref_by,@ref_name,@pt_name,0,0,0,0,0,0,0,0,@unit_id,''N'',@login_id,@card_no)
end  
--Insert Into Sales_Item
if exists(select sale_inv_no from t_sale_master where sale_inv_no=@sale_inv_no and unit_id=@unit_id)
begin
	if not exists(select master_key_id from t_sale_items where master_key_id=@master_key_id and sale_inv_no=@sale_inv_no and unit_id=@unit_id )
	begin
		INSERT INTO t_sale_items  
		(unit_id ,Sale_Inv_No ,Master_Key_id ,Sale_Date, Item_id, Tax_Id, tax_rate, dis_per, SR,Sale_qty,  SV, PV, Amount, taxValue,trf_flag,login_id)
		output inserted.Master_key_id into @confirm
		VALUES  
		(@unit_id,@Sale_Inv_No,@Master_Key_id,convert(varchar(10),getdate(),111),@item_id,@tax_id,@tax_rate,@dis_per, @usr,@sold_qty,@sv,@pv,@Amount,@TaxValue,''N'',@login_id)

		if exists(select result from @confirm)
		begin
			update stocks set quantity=quantity-@sold_qty where  master_key_id=@master_key_id and unit_id=@unit_id;
		end
	end
	else
	begin
		delete from @confirm
		if(@DiscountLogic=''ReCal'')
		begin
			update t_sale_items set  sr=@usr,sv=@sv,taxValue=@TaxValue 
			output inserted.Master_key_id into @confirm
			where master_key_id=@master_key_id and sale_inv_no=@sale_inv_no and unit_id=@unit_id ;
		end
		else if(@DiscountLogic=''New'')
		begin
			update t_sale_items set  sale_qty=sale_qty+@sold_qty, amount=amount+@amount,pv=pv+@pv,sr=@usr,sv=sv+@sv,taxValue=taxValue+@TaxValue 
			output inserted.Master_key_id into @confirm
			where master_key_id=@master_key_id and sale_inv_no=@sale_inv_no and unit_id=@unit_id ;

			if exists(select result from @confirm)
			begin
				update stocks set quantity=quantity-@sold_qty where  master_key_id=@master_key_id and unit_id=@unit_id;
			end
		end
	end

end
--Update t_sale_master 
execute pUpdate_T_Sale_Master @unit_id,@sale_inv_no,@card_no,''N/A'';

select @total=round(total,2),@discount=round(discount,2) from t_sale_master where sale_inv_no=@sale_inv_no 
set @payable=round(@total-@discount,0)
set @roundoff=0
set @result =''Success''

if @@error=0
commit
else
rollback



set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON

' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pTransferStocks]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--Vijay Singh
--20/03/2012
CREATE procedure [dbo].[pTransferStocks]
@trf_id varchar(16)=null output,
@fromstore varchar(10)=null,
@tostore varchar(10)=null,
@item_id varchar(7)=null,
@Master_Key_Id varchar(16)=null,
@qty int =0,
@login_id varchar(10)=null,
@result varchar(50) output
AS
set nocount on;
begin transaction
set @result=''Failed To Transfer ''+@master_key_id;
declare  @incno int, @F_TrfId varchar(16),@no_item int
declare @confirm table(result varchar(16))
if (len(@trf_id)< 4 or @trf_id=''NEW'')
	select @trf_id=[dbo].[fnNewTrfId](getdate())

if (select count(master_key_id) from stocks st WHERE st.unit_id=@fromstore and st.Item_id = @item_id and st.Master_Key_Id=@Master_Key_Id AND  st.quantity>=@qty)>0
begin
	insert into trf_items(trf_id,master_key_id,trf_date,trf_from,trf_to,item_id,qty,login_id)
    output inserted.master_key_id into @confirm
    values (@trf_id,@Master_Key_Id,getdate(),@fromstore,@tostore,@item_id,@qty,@login_id)
	--Update  Stocks
	if exists (Select result from @confirm)
	update stocks set quantity=quantity-@qty where master_key_id=@Master_Key_Id and unit_id=@fromstore


	select @no_item=isnull(count(trf_id),0) from trf_items where trf_id=@trf_id
	if not exists(select trf_id from trf_master where trf_id=@trf_id)
	begin
		insert into trf_master values (@trf_id,@fromstore,@tostore,getdate(),@no_item,@login_id,0)
	end
	else
	begin
		update trf_master set no_of_item=@no_item where trf_id=@trf_id
	end
end
if(@@error=0)
begin
set @result=''Successfully Inserted.''
commit
end
else
rollback tran



set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pReconsileQuerries_Local]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--EXECUTE  pReconsileQuerries_Local ''MS-00033'',''2012/04/01'',''2012/04/19'',''Sale_Master'' 
CREATE procedure [dbo].[pReconsileQuerries_Local]
@unit_id varchar(10),
@prm_1 varchar(20),
@prm_2 varchar(20),
@Logic varchar(20)
As
set nocount on;
IF(@Logic=''Sale_Master'')
BEGIN
  SELECT  convert(varchar,sale_date,111) sale_date,COUNT(sale_inv_no) SML from sale_master  
  where convert(varchar,sale_date,111) between convert(varchar,rtrim(@prm_1),111) and convert(varchar,rtrim(@prm_2),111)
  and unit_id=@unit_id group by convert(varchar,sale_date,111)
END 
ELSE IF(@Logic=''Sale_Items'')
BEGIN
  SELECT  convert(varchar,sale_date,111) sale_date,COUNT(sale_inv_no) SML from sale_ITEMS 
  where convert(varchar,sale_date,111) between convert(varchar,rtrim(@prm_1),111) and convert(varchar,rtrim(@prm_2),111)
  and unit_id=@unit_id group by convert(varchar,sale_date,111)
END            
ELSE IF(@Logic=''STOCK_RECONSILE'')
  select master_key_id,quantity  from stocks where unit_id=@unit_id and quantity!=0
else if(@Logic=''Trf_Rec_Info'')
begin
         select   Trf_Items.Trf_id,Trf_Items.master_key_id, Trf_Items.trf_date, ''Transfer'' AS c_action, Trf_Items.Trf_To, Trf_Items.Trf_To 
         AS TransferTo, Trf_Items.qty, mki.Pack_Type, mki.Pack_Qty, mki.Batch_No, mki.Exp_Date
         from Trf_Items INNER JOIN  Stocks ON Trf_Items.master_key_id = Stocks.Master_Key_id  inner join masterkey_info mki
         on   Stocks.Master_Key_id =mki.Master_Key_id
         where Trf_Items.Trf_From =@unit_id AND Trf_Items.Trf_To !=@unit_id AND Trf_Items.item_id =@prm_1
         Union    
		 select rcpt_items.Trf_id, rcpt_items.master_key_id,rcpt_items.trf_date, ''Received'' AS c_action, rcpt_items.Trf_To, 
         rcpt_items.Trf_from , rcpt_items.qty, mki.Pack_Type, mki.Pack_Qty, mki.Batch_No, 
         mki.Exp_Date FROM rcpt_items INNER JOIN  Stocks ON rcpt_items.master_key_id = Stocks.Master_Key_id 
         inner join masterkey_info mki on Stocks.Master_Key_id =mki.Master_Key_id
         WHERE  rcpt_items.Trf_To =@unit_id AND rcpt_items.item_id = @prm_1
         --fill batchwise information
         select si.item_id,si.master_key_id,pack_type pack_size,pack_qty,batch_no,exp_date,sum(sale_qty) as qty from sale_items si
         inner join masterkey_info mki on si.Master_Key_id =mki.Master_Key_id
         where unit_id=@unit_id and  si.item_id=@prm_1 GROUP BY 
         si.item_id,si.master_key_id,pack_type,pack_qty,batch_no,exp_date
        
         --fill information from stocks 
         select stocks.master_key_id,dbo.fnitemname(stocks.item_id) as item_name,batch_no,exp_date,pack_type,pack_qty,quantity,status_flag status from stocks
         inner join masterkey_info mki
         on   Stocks.Master_Key_id =mki.Master_Key_id
         where unit_id=@unit_id and quantity<>0 and stocks.item_id=@prm_1
end
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pProductMovementInfo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- pProductMovementInfo ''cp22757'',''MS-00033''
CREATE procedure [dbo].[pProductMovementInfo]
@item_id varchar(7),
@unit_id varchar(10)
as
set nocount on
 --Transfer Information Table 0
select   ti.Trf_id,ti.master_key_id, ti.trf_date, ''Trf'' AS c_action, ti.Trf_To, ti.Trf_To 
AS TransferTo, ti.qty, mki.Pack_Type, mki.Pack_Qty, mki.Batch_No, mki.Exp_Date
from     Trf_Items ti
inner join masterkey_info mki ON mki.master_key_id = ti.Master_Key_id
where    ti.Trf_From =@unit_id AND ti.Trf_To !=@unit_id AND ti.item_id =@item_id 
Union    
select rcpt_items.Trf_id, rcpt_items.master_key_id,rcpt_items.trf_date, ''Rcpt'' AS c_action, rcpt_items.Trf_To, 
rcpt_items.Trf_from , rcpt_items.qty, mki.Pack_Type, mki.Pack_Qty, mki.Batch_No, 
mki.Exp_Date FROM rcpt_items INNER JOIN  masterkey_info mki ON rcpt_items.master_key_id = mki.Master_Key_id
WHERE  rcpt_items.Trf_To =@unit_id AND rcpt_items.item_id = @item_id;

--fill batchwise information Table 1
select si.item_id,si.master_key_id,mki.pack_type,mki.pack_qty,mki.batch_no,mki.exp_date,sum(si.sale_qty) as qty from sale_items si
inner join MasterKey_Info mki on si.Item_id=mki.item_id and si.Master_key_id=mki.master_key_id
where unit_id=@unit_id and si.item_id=@item_id 
GROUP BY si.item_id,si.master_key_id,mki.pack_type,pack_qty,batch_no,exp_date;

--fill information from stocks Table 2
select mki.master_key_id,dbo.fnitemname(st.item_id) as item_name,mki.batch_no,
mki.exp_date,mki.pack_type,mki.pack_qty,quantity,status_flag 
from stocks st 
inner join MasterKey_Info mki on mki.master_key_id=st.master_key_id and mki.item_id=st.Item_id
where unit_id=@unit_id and quantity<>0 and st.item_id=@item_id;

--fill Tracing Table 3
select date,opening,sale,transfer,received from (select 1 seq, ''1900-01-01'' as date,op_stock opening,0 sale,0 transfer,0 received  from item_master where item_id=@item_id
union
select 2 seq,sale_date,0 opening,sum(sale_qty) sale,0 transfer,0 received from sale_items where  item_id=@item_id and sale_date>''2008-03-31''
group by sale_date
union
select 2 seq,trf_date,0 opening,0 sale,sum(qty) transfer,0 received from trf_items where  item_id=@item_id and trf_date>''2008-03-31''
group by trf_date
union
select 2 seq,trf_date,0 opening,0 sale,0 transfer,sum(qty) received from rcpt_items where  item_id=@item_id and trf_date>''2008-03-31''
group by trf_date ) x order by date,Seq



set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
' 
END
GO
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UnitItemAnalysis]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE  [dbo].[UnitItemAnalysis]
@shopcode varchar(10),
@itemId varchar(10),
@dt_from datetime,
@dt_to datetime
 AS
declare @OpeningStock int
begin transaction
drop table report

CREATE TABLE Report (
	[cr_date] [datetime] NULL ,
	[Particular] [varchar] (70) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[St_Received] [int] NULL ,
	[St_Trf_Sale] [int] NULL ,
	[RunBal] [int] NULL 
)



select   @OpeningStock=dbo.fnItemOpenStock(@shopcode,@itemid,@dt_from)  
insert into Report values(@dt_from,''Opening Stock '',0,0,@OpeningStock)

insert into Report  select sale_date as cr_date ,''By Sale '' as Particular,0 as St_Received,sum(sale_qty) AS St_Trf_Sale,0 as RunBal  from sale_items 
where unit_id=@ShopCode AND item_id=@itemId and sale_date between @dt_from and @dt_to group by sale_date 
union 
select trf_date AS CR_DATE ,(''By Central Store Vide Trf Id. No ''+trf_id) as Particular,sum(qty) as St_Received,0 AS St_Trf_Sale,0 as RunBal  from RCPT_items 
where  trf_to=@ShopCode  AND ITEM_ID=@itemId  and trf_date between @dt_from and @dt_to GROUP BY trf_date,trf_id
union 
select trf_date AS CR_DATE ,(''To Central Store Vide Trf Id. No ''+trf_id) as Particular,0 as St_Received,sum(qty) AS St_Trf_Sale,0 as RunBal  from trf_items 
where  trf_from=@shopCode    AND ITEM_ID=@itemId  and trf_date between @dt_from and @dt_to GROUP BY trf_date,trf_id

if @@error=0
begin
--select * from Report order by cr_date
commit transaction
end
else
select ''Error'' as Result
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pInsertVoucher]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[pInsertVoucher]
@vch_type varchar(10),
@ledg_debit_name varchar(100),
@ledg_credit_name varchar(100),
@amount money,
@narration varchar(70),
@operator varchar(10),
@GenFrom varchar(10),
@unit_id varchar(10),
@result varchar(50) output
as
declare @ledg_debit_code int,@ledg_credit_code int,@voucherNo varchar(15)
set @voucherno=''New''
set @result=''Failed''
if exists(select * from ledgermaster where ld_name= @ledg_debit_name) and exists(select * from ledgermaster where ld_name= @ledg_credit_name)
begin
	execute pGetNewVoucherNo @voucherNo output
	select @ledg_debit_code=ld_code from ledgermaster where ld_name= @ledg_debit_name
	select @ledg_credit_code=ld_code from ledgermaster where ld_name= @ledg_credit_name
	insert into vouchermaster (voucher_no,vch_type ,vch_date ,ledg_debit,ledg_credit,amount,narration,login_id,GenFrom,unit_id) 
	values(@voucherNo,@vch_type,convert(varchar(10),getdate(),111),@ledg_debit_code,@ledg_credit_code,@amount,@narration,@operator,''AU'',@unit_id)
	select @result=''Inserted''
end
' 
END
