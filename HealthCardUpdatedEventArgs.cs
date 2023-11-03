using System;
using System.Collections.Generic;
using System.Text;
namespace eMediShop
{
    /// <summary>
    /// Defines the signature for the method that the HealthCardUpdated handler need
    /// to support.
    /// </summary>
    public delegate void HealthCardUpdatedEventHandler(object sender, HealthCardUpdatedEventArgs e);
    public delegate void Healeh(object sender, HealthCardUpdatedEventArgs e);


    /// <summary>
    /// Holds the event arguments for the HealthCardUpdated event.
    /// </summary>
    public class HealthCardUpdatedEventArgs : System.EventArgs
    {
        /// <summary>
        /// Used to store the new value
        /// </summary>
        ///
        private string newCardNo;
        private string newCardName;
        private string cardType;
        private decimal discountPercentage;
        private string payMode;
        private string mobileNo;



        /// <summary>
        /// Create a new instance of the ReferralUpdatedEventArgs class.
        /// </summary>
        /// <param name="newValue">represents the change to the value</param>
        /// 
        public HealthCardUpdatedEventArgs(string newCardNo, string newCardName, string cardType, decimal discountPercentage, string payMode,string mobileNo)
        {
            this.newCardNo = newCardNo;
            this.newCardName = newCardName;
            this.cardType = cardType;
            this.discountPercentage = discountPercentage;
            this.payMode = payMode;
            this.mobileNo = mobileNo;
        }
        /// <summary>
        /// Gets the updated value
        /// </summary>
        /// 
        public string NewCardNo { get { return this.newCardNo; } }
        public string NewCardName { get { return this.newCardName; } }
        public string CardType { get { return this.cardType; } }
        public decimal Discountpercentage { get { return this.discountPercentage; } }
        public string PayMode { get { return this.payMode; } }
        public string MobileNo { get { return this.mobileNo; } }
    }
}
