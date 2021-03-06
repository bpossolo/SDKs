
/**
 * Auto generated code
 */

package urn.ebay.api.PayPalAPI;

import urn.ebay.apis.CoreComponentTypes.BasicAmountType;
import urn.ebay.apis.eBLBaseComponents.AbstractRequestType;
import urn.ebay.apis.eBLBaseComponents.CurrencyCodeType;
import urn.ebay.apis.eBLBaseComponents.PaymentTransactionClassCodeType;
import urn.ebay.apis.eBLBaseComponents.PaymentTransactionStatusCodeType;
import urn.ebay.apis.eBLBaseComponents.PersonNameType;


/**
The earliest transaction date at which to start the search. No wildcards are allowed. 
 * Required
 */
public class TransactionSearchRequestType extends AbstractRequestType{

	/**
The earliest transaction date at which to start the search. No wildcards are allowed. 
	 * Required
	 *
	 * @Required
	 */
	private String StartDate;
	public String getStartDate() {
		return StartDate;
	}
	public void setStartDate(String value) {
		this.StartDate = value;
	}

	/**
The latest transaction date to be included in the search 
	 * Optional
	 */
	private String EndDate;
	public String getEndDate() {
		return EndDate;
	}
	public void setEndDate(String value) {
		this.EndDate = value;
	}

	/**
Search by the buyer's email address 
	 * Optional
	 * Character length and limitations: 127 single-byte alphanumeric characters
	 */
	private String Payer;
	public String getPayer() {
		return Payer;
	}
	public void setPayer(String value) {
		this.Payer = value;
	}

	/**
Search by the receiver's email address. If the merchant account has only one email, this is the primary email. Can also be a non-primary email.
	 * Optional
	 */
	private String Receiver;
	public String getReceiver() {
		return Receiver;
	}
	public void setReceiver(String value) {
		this.Receiver = value;
	}

	/**
Search by the PayPal Account Optional receipt ID
	 * Optional
	 */
	private String ReceiptID;
	public String getReceiptID() {
		return ReceiptID;
	}
	public void setReceiptID(String value) {
		this.ReceiptID = value;
	}

	/**
Search by the transaction ID. 
	 * Optional
	 * The returned results are from the merchant's transaction records. 
	 * Character length and limitations: 19 single-byte characters maximum
	 */
	private String TransactionID;
	public String getTransactionID() {
		return TransactionID;
	}
	public void setTransactionID(String value) {
		this.TransactionID = value;
	}

	/**
Search by Recurring Payment Profile id.  The ProfileID is returned as part of the CreateRecurringPaymentsProfile API response. 
	 * Optional
	 */
	private String ProfileID;
	public String getProfileID() {
		return ProfileID;
	}
	public void setProfileID(String value) {
		this.ProfileID = value;
	}

	/**
Search by Store Id. It is mandatory field if Terminal Id is specified as one of the search parameters.
	 * Optional
	 */
	private String StoreID;
	public String getStoreID() {
		return StoreID;
	}
	public void setStoreID(String value) {
		this.StoreID = value;
	}

	/**
Search by Store Id and Terminal Id. If the Terminal Id field is specified as one of the search parameters, then there should be a valid Store Id value set in the StoreID field.
	 * Optional
	 */
	private String TerminalID;
	public String getTerminalID() {
		return TerminalID;
	}
	public void setTerminalID(String value) {
		this.TerminalID = value;
	}

	/**
Search by the buyer's name 
	 * Optional
	 * Salutation: 20 single-byte character limit.
	 * FirstName: 25 single-byte character limit.
	 * MiddleName: 25 single-byte character limit.
	 * LastName: 25 single-byte character limit.
	 * Suffix: 12 single-byte character limit.
	 */
	private PersonNameType PayerName;
	public PersonNameType getPayerName() {
		return PayerName;
	}
	public void setPayerName(PersonNameType value) {
		this.PayerName = value;
	}

	/**
Search by item number of the purchased goods.
	 * Optional
	 * To search for purchased items not related to auctions, set the AuctionItemNumber element to the value of the HTML item_number variable set in the shopping cart for the original transaction.	 */
	private String AuctionItemNumber;
	public String getAuctionItemNumber() {
		return AuctionItemNumber;
	}
	public void setAuctionItemNumber(String value) {
		this.AuctionItemNumber = value;
	}

	/**
Search by invoice identification key, as set by you for the original transaction. InvoiceID searches the invoice records for items sold by the merchant, not the items purchased. 
	 * Optional
	 * The value for InvoiceID must exactly match an invoice identification number. No wildcards are allowed. 
	 * Character length and limitations: 127 single-byte characters maximum	 */
	private String InvoiceID;
	public String getInvoiceID() {
		return InvoiceID;
	}
	public void setInvoiceID(String value) {
		this.InvoiceID = value;
	}

	/**
	 */
	private String CardNumber;
	public String getCardNumber() {
		return CardNumber;
	}
	public void setCardNumber(String value) {
		this.CardNumber = value;
	}

	/**
	 * Search by classification of transaction. Some kinds of possible classes of transactions are not searchable with TransactionSearchRequest. You cannot search for bank transfer withdrawals, for example. 
	 * Optional
	 * All: all transaction classifications.
	 * Sent: only payments sent.
	 * Received: only payments received.
	 * MassPay: only mass payments.
	 * MoneyRequest: only money requests.
	 * FundsAdded: only funds added to balance.
	 * FundsWithdrawn: only funds withdrawn from balance.
	 * Referral: only transactions involving referrals.
	 * Fee: only transactions involving fees.
	 * Subscription: only transactions involving subscriptions.
	 * Dividend: only transactions involving dividends.
	 * Billpay: only transactions involving BillPay Transactions.
	 * Refund: only transactions involving funds.
	 * CurrencyConversions: only transactions involving currency conversions.
	 * BalanceTransfer: only transactions involving balance transfers.
	 * Reversal: only transactions involving BillPay reversals.
	 * Shipping: only transactions involving UPS shipping fees.
	 * BalanceAffecting: only transactions that affect the account balance.
	 * ECheck: only transactions involving eCheck
	 */
	private PaymentTransactionClassCodeType TransactionClass;
	public PaymentTransactionClassCodeType getTransactionClass() {
		return TransactionClass;
	}
	public void setTransactionClass(PaymentTransactionClassCodeType value) {
		this.TransactionClass = value;
	}

	/**
Search by transaction amount 
	 * Optional
	 * You must set the currencyID attribute to one of the three-character currency codes for any of the supported PayPal currencies. 	 */
	private BasicAmountType Amount;
	public BasicAmountType getAmount() {
		return Amount;
	}
	public void setAmount(BasicAmountType value) {
		this.Amount = value;
	}

	/**
Search by currency code
	 * Optional
	 */
	private CurrencyCodeType CurrencyCode;
	public CurrencyCodeType getCurrencyCode() {
		return CurrencyCode;
	}
	public void setCurrencyCode(CurrencyCodeType value) {
		this.CurrencyCode = value;
	}

	/**
Search by transaction status 
	 * Optional
	 * Pending: The payment is pending. The specific reason the payment is pending is returned by the GetTransactionDetails APIPendingReason element. For more information, see PendingReason.
	 * Processing: The payment is being processed.
	 * Success: The payment has been completed and the funds have been added successfully to your account balance.
	 * Denied: You denied the payment. This happens only if the payment was previously pending.
	 * Reversed: A payment was reversed due to a chargeback or other type of reversal. The funds have been removed from your account balance and returned to the buyer.
	 */
	private PaymentTransactionStatusCodeType Status;
	public PaymentTransactionStatusCodeType getStatus() {
		return Status;
	}
	public void setStatus(PaymentTransactionStatusCodeType value) {
		this.Status = value;
	}


	public TransactionSearchRequestType(String StartDate) {
		this.StartDate = StartDate;
	}
	public TransactionSearchRequestType() {
	}

	public String toXMLString()  {
		StringBuilder sb = new StringBuilder();
sb.append(super.toXMLString());
		if( StartDate != null ) {
			sb.append("<urn:StartDate>").append(StartDate);
			sb.append("</urn:StartDate>");
		}
		if( EndDate != null ) {
			sb.append("<urn:EndDate>").append(EndDate);
			sb.append("</urn:EndDate>");
		}
		if( Payer != null ) {
			sb.append("<urn:Payer>").append(Payer);
			sb.append("</urn:Payer>");
		}
		if( Receiver != null ) {
			sb.append("<urn:Receiver>").append(Receiver);
			sb.append("</urn:Receiver>");
		}
		if( ReceiptID != null ) {
			sb.append("<urn:ReceiptID>").append(ReceiptID);
			sb.append("</urn:ReceiptID>");
		}
		if( TransactionID != null ) {
			sb.append("<urn:TransactionID>").append(TransactionID);
			sb.append("</urn:TransactionID>");
		}
		if( ProfileID != null ) {
			sb.append("<urn:ProfileID>").append(ProfileID);
			sb.append("</urn:ProfileID>");
		}
		if( StoreID != null ) {
			sb.append("<urn:StoreID>").append(StoreID);
			sb.append("</urn:StoreID>");
		}
		if( TerminalID != null ) {
			sb.append("<urn:TerminalID>").append(TerminalID);
			sb.append("</urn:TerminalID>");
		}
		if( PayerName != null ) {
			sb.append("<urn:PayerName>");
			sb.append(PayerName.toXMLString());
			sb.append("</urn:PayerName>");
		}
		if( AuctionItemNumber != null ) {
			sb.append("<urn:AuctionItemNumber>").append(AuctionItemNumber);
			sb.append("</urn:AuctionItemNumber>");
		}
		if( InvoiceID != null ) {
			sb.append("<urn:InvoiceID>").append(InvoiceID);
			sb.append("</urn:InvoiceID>");
		}
		if( CardNumber != null ) {
			sb.append("<urn:CardNumber>").append(CardNumber);
			sb.append("</urn:CardNumber>");
		}
		if( TransactionClass != null ) {
			sb.append("<urn:TransactionClass>").append( TransactionClass.getValue());
			sb.append("</urn:TransactionClass>");
		}
		if( Amount != null ) {
			sb.append("<urn:Amount ");
			sb.append(Amount.toXMLString());
			sb.append("</urn:Amount>");
		}
		if( CurrencyCode != null ) {
			sb.append("<urn:CurrencyCode>").append( CurrencyCode.getValue());
			sb.append("</urn:CurrencyCode>");
		}
		if( Status != null ) {
			sb.append("<urn:Status>").append( Status.getValue());
			sb.append("</urn:Status>");
		}
		return sb.toString();
	}

}
