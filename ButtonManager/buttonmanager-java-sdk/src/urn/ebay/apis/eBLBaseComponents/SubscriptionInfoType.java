
/**
 * Auto generated code
 */

package urn.ebay.apis.eBLBaseComponents;

import java.io.FileInputStream;
import java.io.IOException;
import java.io.StringReader;
import java.util.ArrayList;
import java.util.List;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import org.w3c.dom.Document;
import org.w3c.dom.NamedNodeMap;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import org.xml.sax.InputSource;
import org.xml.sax.SAXException;
import urn.ebay.apis.eBLBaseComponents.SubscriptionTermsType;


/**
 * SubscriptionInfoType 
 * Information about a PayPal Subscription.
 */
public class SubscriptionInfoType {

	/**
	 * ID generated by PayPal for the subscriber. 
Character length and limitations: no limit	 */
	private String SubscriptionID;
	public String getSubscriptionID() {
		return SubscriptionID;
	}
	public void setSubscriptionID(String value) {
		this.SubscriptionID = value;
	}

	/**
	 * Subscription start date 	 */
	private String SubscriptionDate;
	public String getSubscriptionDate() {
		return SubscriptionDate;
	}
	public void setSubscriptionDate(String value) {
		this.SubscriptionDate = value;
	}

	/**
	 * Date when the subscription modification will be effective 	 */
	private String EffectiveDate;
	public String getEffectiveDate() {
		return EffectiveDate;
	}
	public void setEffectiveDate(String value) {
		this.EffectiveDate = value;
	}

	/**
	 * Date PayPal will retry a failed subscription payment 	 */
	private String RetryTime;
	public String getRetryTime() {
		return RetryTime;
	}
	public void setRetryTime(String value) {
		this.RetryTime = value;
	}

	/**
	 * Username generated by PayPal and given to subscriber to access the subscription. 
Character length and limitations: 64 alphanumeric single-byte characters	 */
	private String Username;
	public String getUsername() {
		return Username;
	}
	public void setUsername(String value) {
		this.Username = value;
	}

	/**
	 * Password generated by PayPal and given to subscriber to access the subscription. For security, the value of the password is hashed. 
Character length and limitations: 128 alphanumeric single-byte characters	 */
	private String Password;
	public String getPassword() {
		return Password;
	}
	public void setPassword(String value) {
		this.Password = value;
	}

	/**
	 * The number of payment installments that will occur at the regular rate. 
Character length and limitations: no limit	 */
	private String Recurrences;
	public String getRecurrences() {
		return Recurrences;
	}
	public void setRecurrences(String value) {
		this.Recurrences = value;
	}

	/**
	 * Subscription duration and charges	 */
	private List<SubscriptionTermsType> Terms = new ArrayList<SubscriptionTermsType>();
	public List<SubscriptionTermsType> getTerms() {
		return Terms;
	}
	public void setTerms(List<SubscriptionTermsType> value) {
		this.Terms = value;
	}


	public SubscriptionInfoType() {
	}
	 private  boolean isWhitespaceNode(Node n) {
		 if (n.getNodeType() == Node.TEXT_NODE) { 
				String val = n.getNodeValue();
				return val.trim().length() == 0; 
		 } else {
				return false;
		 } 
	 } 
	 private String convertToXML(Node n){ 
		 String name = n.getNodeName();
		 short type = n.getNodeType();
		 if (Node.CDATA_SECTION_NODE == type) {
			  return "<![CDATA[" + n.getNodeValue() + "]]&gt;";
		 } 
		 if (name.startsWith("#")) {
			  return "";
		} 
		 StringBuffer sb = new StringBuffer();
		 sb.append('<').append(name);
		 NamedNodeMap attrs = n.getAttributes();
		 if (attrs != null) { 
		  for (int i = 0; i < attrs.getLength(); i++) { 
			    Node attr = attrs.item(i);
			    sb.append(' ').append(attr.getNodeName()).append("=\"").append(attr.getNodeValue()).append("\"");
		  }
		 } 
		 String textContent = null; 
		 NodeList children = n.getChildNodes(); 
		 if (children.getLength() == 0) { 
		  if ((textContent = n.getTextContent()) != null && !"".equals(textContent)) {
		    sb.append(textContent).append("</").append(name).append('>'); 
		  } else { 
		    sb.append("/>"); 
		  } 
		 } else { 
		  sb.append('>'); 
		  boolean hasValidChildren = false;
		  for (int i = 0; i < children.getLength(); i++) { 
		    String childToString = convertToXML(children.item(i));
		    if (!"".equals(childToString)) {
		      sb.append(childToString); 
		      hasValidChildren = true; 
		    } 
		  } 
		  if (!hasValidChildren && ((textContent = n.getTextContent()) != null)) { 
		    sb.append(textContent); 
		 }
		  sb.append("</").append(name).append('>');
		 }
		 return sb.toString();
	 } 
	 public SubscriptionInfoType(Object xmlSoap) throws IOException,SAXException,ParserConfigurationException	{
		 DocumentBuilderFactory builderFactory = DocumentBuilderFactory.newInstance();
		 DocumentBuilder builder = builderFactory.newDocumentBuilder();
		 InputSource inStream = new InputSource(); 
		 inStream.setCharacterStream(new StringReader((String)xmlSoap));
		 Document document = builder.parse(inStream);
		 NodeList nodeList= null; 
		 String xmlString ="";
		 if(document.getElementsByTagName("SubscriptionID").getLength()!=0){		 if(!isWhitespaceNode(document.getElementsByTagName("SubscriptionID").item(0))){ 
		 this.SubscriptionID =(String)document.getElementsByTagName("SubscriptionID").item(0).getTextContent();

}
	}
		 if(document.getElementsByTagName("SubscriptionDate").getLength()!=0){		 if(!isWhitespaceNode(document.getElementsByTagName("SubscriptionDate").item(0))){ 
		 this.SubscriptionDate =(String)document.getElementsByTagName("SubscriptionDate").item(0).getTextContent();

}
	}
		 if(document.getElementsByTagName("EffectiveDate").getLength()!=0){		 if(!isWhitespaceNode(document.getElementsByTagName("EffectiveDate").item(0))){ 
		 this.EffectiveDate =(String)document.getElementsByTagName("EffectiveDate").item(0).getTextContent();

}
	}
		 if(document.getElementsByTagName("RetryTime").getLength()!=0){		 if(!isWhitespaceNode(document.getElementsByTagName("RetryTime").item(0))){ 
		 this.RetryTime =(String)document.getElementsByTagName("RetryTime").item(0).getTextContent();

}
	}
		 if(document.getElementsByTagName("Username").getLength()!=0){		 if(!isWhitespaceNode(document.getElementsByTagName("Username").item(0))){ 
		 this.Username =(String)document.getElementsByTagName("Username").item(0).getTextContent();

}
	}
		 if(document.getElementsByTagName("Password").getLength()!=0){		 if(!isWhitespaceNode(document.getElementsByTagName("Password").item(0))){ 
		 this.Password =(String)document.getElementsByTagName("Password").item(0).getTextContent();

}
	}
		 if(document.getElementsByTagName("Recurrences").getLength()!=0){		 if(!isWhitespaceNode(document.getElementsByTagName("Recurrences").item(0))){ 
		 this.Recurrences =(String)document.getElementsByTagName("Recurrences").item(0).getTextContent();

}
	}
		 if(document.getElementsByTagName("Terms").getLength()!=0){		 if(!isWhitespaceNode(document.getElementsByTagName("Terms").item(0))){ 
		 nodeList = document.getElementsByTagName("Terms");
		 for(int i=0; i<nodeList.getLength(); i++) {
			 xmlString = convertToXML(nodeList.item(i)); 
				this.Terms.add(new SubscriptionTermsType(xmlString));
			}

}
	}
	}
}
