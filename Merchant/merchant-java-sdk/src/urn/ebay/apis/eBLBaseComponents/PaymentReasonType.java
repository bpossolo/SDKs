/**
 * Auto generated code
 * PaymentReasonType
 * This is the Payment Reason type (used by DoRT and SetEC for Refund of PI transaction, eBay return shipment, external dispute)
 */
package urn.ebay.apis.eBLBaseComponents;

public enum PaymentReasonType {

 		NONE("None"),
 		REFUND("Refund"),
 		RETURNSHIPMENT("ReturnShipment"),
		;
		private String value;
		PaymentReasonType(String val){
			value=val;
		}		public String getValue(){
			return value;
		}
		public static PaymentReasonType fromValue(String v) {
			for (PaymentReasonType c : values())
				if (c.value.equals(v))
					return c;
			throw new IllegalArgumentException(v);
		}
}
