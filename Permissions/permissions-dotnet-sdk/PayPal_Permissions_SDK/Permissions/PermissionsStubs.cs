namespace PayPal.Permissions.Model {
	using System;
	using System.Text;
	using System.Web;
	using System.Xml;
	using System.Collections;
	using System.ComponentModel;
	using System.Collections.Generic;
	using PayPal.Util;

	public class EnumUtils{
		public static string getDescription(Enum value){
			string description="";
			DescriptionAttribute[] attributes = (DescriptionAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
			if (attributes.Length > 0)
			{
				description= attributes[0].Description;
			}
			return description;
		}
		public static object getValue(String value,Type enumType){
			string[] names = Enum.GetNames(enumType);
			foreach (string name in names)
			{
				if (getDescription((Enum)Enum.Parse(enumType, name)).Equals(value))
				{
					return Enum.Parse(enumType, name);
				}
			}
			return null;
		}
	}
	public enum AckCode {
[Description("Success")]SUCCESS,
[Description("Failure")]FAILURE,
[Description("Warning")]WARNING,
[Description("SuccessWithWarning")]SUCCESSWITHWARNING,
[Description("FailureWithWarning")]FAILUREWITHWARNING,
[Description("CustomCode")]CUSTOMCODE,
	}
	/**
	 * Request to invalidate an access token and revoke
	 * the permissions associated with it.
	 */
	public partial class CancelPermissionsRequest {

		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope {
			get {
				return this.requestEnvelopeField;
			}
			set {
				this.requestEnvelopeField = value;
			}
		}

		private string tokenField;
		public string token {
			get {
				return this.tokenField;
			}
			set {
				this.tokenField = value;
			}
		}

		public CancelPermissionsRequest(string token) {
			this.token = token;
		}
		public CancelPermissionsRequest() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null) {
				string newPrefix = prefix + "requestEnvelope" + '.';
				sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.token != null) {
				sb.Append(prefix).Append("token").Append('=').Append(HttpUtility.UrlEncode(this.token, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			return sb.ToString();
		}

	}


	/**
	 */
	public partial class CancelPermissionsResponse {

		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope {
			get {
				return this.responseEnvelopeField;
			}
			set {
				this.responseEnvelopeField = value;
			}
		}

		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error {
			get {
				return this.errorField;
			}
			set {
				this.errorField = value;
			}
		}

	 public CancelPermissionsResponse(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if (map.ContainsKey(key + ".timestamp")) {
				this.responseEnvelope = new ResponseEnvelope(map, key + '.');
			}
			i = 0;
			while(true) {
				key = prefix + "error" + '(' + i + ")";
				if (map.ContainsKey(key + ".errorId")) {
					this.error.Add( new ErrorData(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	public enum ErrorCategory {
[Description("System")]SYSTEM,
[Description("Application")]APPLICATION,
[Description("Request")]REQUEST,
	}
	/**
	 */
	public partial class ErrorData {

		private int? errorIdField;
		public int? errorId {
			get {
				return this.errorIdField;
			}
			set {
				this.errorIdField = value;
			}
		}

		private string domainField;
		public string domain {
			get {
				return this.domainField;
			}
			set {
				this.domainField = value;
			}
		}

		private string subdomainField;
		public string subdomain {
			get {
				return this.subdomainField;
			}
			set {
				this.subdomainField = value;
			}
		}

		private ErrorSeverity? severityField;
		public ErrorSeverity? severity {
			get {
				return this.severityField;
			}
			set {
				this.severityField = value;
			}
		}

		private ErrorCategory? categoryField;
		public ErrorCategory? category {
			get {
				return this.categoryField;
			}
			set {
				this.categoryField = value;
			}
		}

		private string messageField;
		public string message {
			get {
				return this.messageField;
			}
			set {
				this.messageField = value;
			}
		}

		private string exceptionIdField;
		public string exceptionId {
			get {
				return this.exceptionIdField;
			}
			set {
				this.exceptionIdField = value;
			}
		}

		private List<ErrorParameter> parameterField = new List<ErrorParameter>();
		public List<ErrorParameter> parameter {
			get {
				return this.parameterField;
			}
			set {
				this.parameterField = value;
			}
		}

	 public ErrorData(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "errorId";
			if (map.ContainsKey(key)) {
				this.errorId = System.Convert.ToInt32( map[key] );
			}
			key = prefix + "domain";
			if (map.ContainsKey(key)) {
				this.domain = map[key];
			}
			key = prefix + "subdomain";
			if (map.ContainsKey(key)) {
				this.subdomain = map[key];
			}
			key = prefix + "severity";
			if (map.ContainsKey(key)) {
				this.severity = (ErrorSeverity)EnumUtils.getValue(map[key],typeof(ErrorSeverity));;
			}
			key = prefix + "category";
			if (map.ContainsKey(key)) {
				this.category = (ErrorCategory)EnumUtils.getValue(map[key],typeof(ErrorCategory));;
			}
			key = prefix + "message";
			if (map.ContainsKey(key)) {
				this.message = map[key];
			}
			key = prefix + "exceptionId";
			if (map.ContainsKey(key)) {
				this.exceptionId = map[key];
			}
			i = 0;
			while(true) {
				key = prefix + "parameter" + '(' + i + ")";
				if (map.ContainsKey(key + ".name")) {
					this.parameter.Add( new ErrorParameter(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	/**
	 */
	public partial class ErrorParameter {

		private string nameField;
		public string name {
			get {
				return this.nameField;
			}
			set {
				this.nameField = value;
			}
		}

		private string valueField;
		public string value {
			get {
				return this.valueField;
			}
			set {
				this.valueField = value;
			}
		}

	 public ErrorParameter(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "name";
			if (map.ContainsKey(key)) {
				this.name = map[key];
			}
			key = prefix + "value";
			if (map.ContainsKey(key)) {
				this.value = map[key];
			}
		}
	}


	public enum ErrorSeverity {
[Description("Error")]ERROR,
[Description("Warning")]WARNING,
	}
	/**
	 */
	public partial class FaultMessage {

		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope {
			get {
				return this.responseEnvelopeField;
			}
			set {
				this.responseEnvelopeField = value;
			}
		}

		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error {
			get {
				return this.errorField;
			}
			set {
				this.errorField = value;
			}
		}

	 public FaultMessage(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if (map.ContainsKey(key + ".timestamp")) {
				this.responseEnvelope = new ResponseEnvelope(map, key + '.');
			}
			i = 0;
			while(true) {
				key = prefix + "error" + '(' + i + ")";
				if (map.ContainsKey(key + ".errorId")) {
					this.error.Add( new ErrorData(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	/**
	 * The request use to retrieve a permanent access
	 * token. The client can either send the token and
	 * verifier, or a subject.
	 */
	public partial class GetAccessTokenRequest {

		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope {
			get {
				return this.requestEnvelopeField;
			}
			set {
				this.requestEnvelopeField = value;
			}
		}

		/**
		 * The temporary request token received
		 * from the RequestPermissions call.
		 */
		private string tokenField;
		public string token {
			get {
				return this.tokenField;
			}
			set {
				this.tokenField = value;
			}
		}

		/**
		 * The verifier code returned to the client
		 * after the user authorization flow
		 * completed.
		 */
		private string verifierField;
		public string verifier {
			get {
				return this.verifierField;
			}
			set {
				this.verifierField = value;
			}
		}

		/**
		 * The subject email address used to
		 * represent existing 3rd Party Permissions
		 * relationship. This field can be used in
		 * lieu of the token and verifier.
		 */
		private string subjectAliasField;
		public string subjectAlias {
			get {
				return this.subjectAliasField;
			}
			set {
				this.subjectAliasField = value;
			}
		}

		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null) {
				string newPrefix = prefix + "requestEnvelope" + '.';
				sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.token != null) {
				sb.Append(prefix).Append("token").Append('=').Append(HttpUtility.UrlEncode(this.token, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.verifier != null) {
				sb.Append(prefix).Append("verifier").Append('=').Append(HttpUtility.UrlEncode(this.verifier, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			if (this.subjectAlias != null) {
				sb.Append(prefix).Append("subjectAlias").Append('=').Append(HttpUtility.UrlEncode(this.subjectAlias, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			return sb.ToString();
		}

	}


	/**
	 * Permanent access token and token secret that can
	 * be used to make requests for protected resources
	 * owned by another account.
	 */
	public partial class GetAccessTokenResponse {

		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope {
			get {
				return this.responseEnvelopeField;
			}
			set {
				this.responseEnvelopeField = value;
			}
		}

		/**
		 * Identifier for the permissions approved
		 * for this relationship.
		 */
		private List<string> scopeField = new List<string>();
		public List<string> scope {
			get {
				return this.scopeField;
			}
			set {
				this.scopeField = value;
			}
		}

		/**
		 * Permanent access token that identifies
		 * the relationship that the user
		 * authorized.
		 */
		private string tokenField;
		public string token {
			get {
				return this.tokenField;
			}
			set {
				this.tokenField = value;
			}
		}

		/**
		 * The token secret/password that will need
		 * to be used when generating the
		 * signature.
		 */
		private string tokenSecretField;
		public string tokenSecret {
			get {
				return this.tokenSecretField;
			}
			set {
				this.tokenSecretField = value;
			}
		}

		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error {
			get {
				return this.errorField;
			}
			set {
				this.errorField = value;
			}
		}

	 public GetAccessTokenResponse(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if (map.ContainsKey(key + ".timestamp")) {
				this.responseEnvelope = new ResponseEnvelope(map, key + '.');
			}
			i = 0;
			while(true) {
			key = prefix + "scope" + '(' + i + ')';
					if (map.ContainsKey(key)) {
						this.scope.Add( map[key]);
					}
				else break;
				i++;
			}
			key = prefix + "token";
			if (map.ContainsKey(key)) {
				this.token = map[key];
			}
			key = prefix + "tokenSecret";
			if (map.ContainsKey(key)) {
				this.tokenSecret = map[key];
			}
			i = 0;
			while(true) {
				key = prefix + "error" + '(' + i + ")";
				if (map.ContainsKey(key + ".errorId")) {
					this.error.Add( new ErrorData(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	/**
	 * Request to retrieve personal data.Accepts PersonalAttributeList as request and responds with PersonalDataList.
	 * This call will accept both 'Basic' and Advanced attributes. 
	 */
	public partial class GetAdvancedPersonalDataRequest {

		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope {
			get {
				return this.requestEnvelopeField;
			}
			set {
				this.requestEnvelopeField = value;
			}
		}

		private PersonalAttributeList attributeListField;
		public PersonalAttributeList attributeList {
			get {
				return this.attributeListField;
			}
			set {
				this.attributeListField = value;
			}
		}

		public GetAdvancedPersonalDataRequest(PersonalAttributeList attributeList) {
			this.attributeList = attributeList;
		}
		public GetAdvancedPersonalDataRequest() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null) {
				string newPrefix = prefix + "requestEnvelope" + '.';
				sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.attributeList != null) {
				string newPrefix = prefix + "attributeList" + '.';
				sb.Append(this.attributeListField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}

	}


	/**
	 */
	public partial class GetAdvancedPersonalDataResponse {

		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope {
			get {
				return this.responseEnvelopeField;
			}
			set {
				this.responseEnvelopeField = value;
			}
		}

		private PersonalDataList responseField;
		public PersonalDataList response {
			get {
				return this.responseField;
			}
			set {
				this.responseField = value;
			}
		}

		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error {
			get {
				return this.errorField;
			}
			set {
				this.errorField = value;
			}
		}

	 public GetAdvancedPersonalDataResponse(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if (map.ContainsKey(key + ".timestamp")) {
				this.responseEnvelope = new ResponseEnvelope(map, key + '.');
			}
			key = prefix + "response";
			if (map.ContainsKey(key + ".personalData(0).personalDataValue")) {
				this.response = new PersonalDataList(map, key + '.');
			}
			i = 0;
			while(true) {
				key = prefix + "error" + '(' + i + ")";
				if (map.ContainsKey(key + ".errorId")) {
					this.error.Add( new ErrorData(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	/**
	 * Request to retrieve basic personal data.Accepts PersonalAttributeList as request and responds with PersonalDataList.
	 * This call will accept only 'Basic' attributes and ignore others. 
	 */
	public partial class GetBasicPersonalDataRequest {

		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope {
			get {
				return this.requestEnvelopeField;
			}
			set {
				this.requestEnvelopeField = value;
			}
		}

		private PersonalAttributeList attributeListField;
		public PersonalAttributeList attributeList {
			get {
				return this.attributeListField;
			}
			set {
				this.attributeListField = value;
			}
		}

		public GetBasicPersonalDataRequest(PersonalAttributeList attributeList) {
			this.attributeList = attributeList;
		}
		public GetBasicPersonalDataRequest() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null) {
				string newPrefix = prefix + "requestEnvelope" + '.';
				sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.attributeList != null) {
				string newPrefix = prefix + "attributeList" + '.';
				sb.Append(this.attributeListField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}

	}


	/**
	 */
	public partial class GetBasicPersonalDataResponse {

		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope {
			get {
				return this.responseEnvelopeField;
			}
			set {
				this.responseEnvelopeField = value;
			}
		}

		private PersonalDataList responseField;
		public PersonalDataList response {
			get {
				return this.responseField;
			}
			set {
				this.responseField = value;
			}
		}

		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error {
			get {
				return this.errorField;
			}
			set {
				this.errorField = value;
			}
		}

	 public GetBasicPersonalDataResponse(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if (map.ContainsKey(key + ".timestamp")) {
				this.responseEnvelope = new ResponseEnvelope(map, key + '.');
			}
			key = prefix + "response";
			if (map.ContainsKey(key + ".personalData(0).personalDataValue")) {
				this.response = new PersonalDataList(map, key + '.');
			}
			i = 0;
			while(true) {
				key = prefix + "error" + '(' + i + ")";
				if (map.ContainsKey(key + ".errorId")) {
					this.error.Add( new ErrorData(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	/**
	 * Request to retrieve the approved list of
	 * permissions associated with a token.
	 */
	public partial class GetPermissionsRequest {

		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope {
			get {
				return this.requestEnvelopeField;
			}
			set {
				this.requestEnvelopeField = value;
			}
		}

		/**
		 * The permanent access token to ask about.
		 */
		private string tokenField;
		public string token {
			get {
				return this.tokenField;
			}
			set {
				this.tokenField = value;
			}
		}

		public GetPermissionsRequest(string token) {
			this.token = token;
		}
		public GetPermissionsRequest() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null) {
				string newPrefix = prefix + "requestEnvelope" + '.';
				sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.token != null) {
				sb.Append(prefix).Append("token").Append('=').Append(HttpUtility.UrlEncode(this.token, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			return sb.ToString();
		}

	}


	/**
	 * The list of permissions associated with the
	 * token.
	 */
	public partial class GetPermissionsResponse {

		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope {
			get {
				return this.responseEnvelopeField;
			}
			set {
				this.responseEnvelopeField = value;
			}
		}

		/**
		 * Identifier for the permissions approved
		 * for this relationship.
		 */
		private List<string> scopeField = new List<string>();
		public List<string> scope {
			get {
				return this.scopeField;
			}
			set {
				this.scopeField = value;
			}
		}

		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error {
			get {
				return this.errorField;
			}
			set {
				this.errorField = value;
			}
		}

	 public GetPermissionsResponse(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if (map.ContainsKey(key + ".timestamp")) {
				this.responseEnvelope = new ResponseEnvelope(map, key + '.');
			}
			i = 0;
			while(true) {
			key = prefix + "scope" + '(' + i + ')';
					if (map.ContainsKey(key)) {
						this.scope.Add( map[key]);
					}
				else break;
				i++;
			}
			i = 0;
			while(true) {
				key = prefix + "error" + '(' + i + ")";
				if (map.ContainsKey(key + ".errorId")) {
					this.error.Add( new ErrorData(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	public enum PersonalAttribute {
[Description("http://axschema.org/namePerson/first")]HTTPAXSCHEMAORGNAMEPERSONFIRST,
[Description("http://axschema.org/namePerson/last")]HTTPAXSCHEMAORGNAMEPERSONLAST,
[Description("http://axschema.org/contact/email")]HTTPAXSCHEMAORGCONTACTEMAIL,
[Description("http://schema.openid.net/contact/fullname")]HTTPSCHEMAOPENIDNETCONTACTFULLNAME,
[Description("http://axschema.org/company/name")]HTTPAXSCHEMAORGCOMPANYNAME,
[Description("http://axschema.org/contact/country/home")]HTTPAXSCHEMAORGCONTACTCOUNTRYHOME,
[Description("http://axschema.org/birthDate")]HTTPAXSCHEMAORGBIRTHDATE,
[Description("http://axschema.org/contact/postalCode/home")]HTTPAXSCHEMAORGCONTACTPOSTALCODEHOME,
[Description("http://schema.openid.net/contact/street1")]HTTPSCHEMAOPENIDNETCONTACTSTREET1,
[Description("http://schema.openid.net/contact/street2")]HTTPSCHEMAOPENIDNETCONTACTSTREET,
[Description("http://axschema.org/contact/city/home")]HTTPAXSCHEMAORGCONTACTCITYHOME,
[Description("http://axschema.org/contact/state/home")]HTTPAXSCHEMAORGCONTACTSTATEHOME,
[Description("http://axschema.org/contact/phone/default")]HTTPAXSCHEMAORGCONTACTPHONEDEFAULT,
[Description("https://www.paypal.com/webapps/auth/schema/payerID")]HTTPSWWWPAYPALCOMWEBAPPSAUTHSCHEMAPAYERID2,
	}
	/**
	 * List of Personal Attributes to be sent as a request. 
	 */
	public partial class PersonalAttributeList {

		private List<PersonalAttribute?> attributeField = new List<PersonalAttribute?>();
		public List<PersonalAttribute?> attribute {
			get {
				return this.attributeField;
			}
			set {
				this.attributeField = value;
			}
		}

		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < this.attribute.Count; i++) {
				if (this.attribute[i] != null) {
				sb.Append(prefix).Append("attribute").Append(i).Append(")=").Append(EnumUtils.getDescription(attribute[i]));
				sb.Append('&');
				}
			}
			return sb.ToString();
		}

	}


	/**
	 * A property of User Identity data , represented as a Name-value pair with Name being the PersonalAttribute requested and value being the data.
	 */
	public partial class PersonalData {

		private PersonalAttribute? personalDataKeyField;
		public PersonalAttribute? personalDataKey {
			get {
				return this.personalDataKeyField;
			}
			set {
				this.personalDataKeyField = value;
			}
		}

		private string personalDataValueField;
		public string personalDataValue {
			get {
				return this.personalDataValueField;
			}
			set {
				this.personalDataValueField = value;
			}
		}

	 public PersonalData(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "personalDataKey";
			if (map.ContainsKey(key)) {
				this.personalDataKey = (PersonalAttribute)EnumUtils.getValue(map[key],typeof(PersonalAttribute));;
			}
			key = prefix + "personalDataValue";
			if (map.ContainsKey(key)) {
				this.personalDataValue = map[key];
			}
		}
	}


	/**
	 * Set of personal data which forms the response of GetPersonalData call.
	 */
	public partial class PersonalDataList {

		private List<PersonalData> personalDataField = new List<PersonalData>();
		public List<PersonalData> personalData {
			get {
				return this.personalDataField;
			}
			set {
				this.personalDataField = value;
			}
		}

	 public PersonalDataList(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			i = 0;
			while(true) {
				key = prefix + "personalData" + '(' + i + ")";
				if (map.ContainsKey(key + ".personalDataValue")) {
					this.personalData.Add( new PersonalData(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	/**
	 * This specifies the list of parameters with every
	 * request to the service.
	 */
	public partial class RequestEnvelope {

		/**
		 * This should be the standard RFC 3066
		 * language identification tag, e.g.,
		 * en_US.
		 */
		private string errorLanguageField;
		public string errorLanguage {
			get {
				return this.errorLanguageField;
			}
			set {
				this.errorLanguageField = value;
			}
		}

		public RequestEnvelope(string errorLanguage) {
			this.errorLanguage = errorLanguage;
		}
		public RequestEnvelope() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.errorLanguage != null) {
				sb.Append(prefix).Append("errorLanguage").Append('=').Append(HttpUtility.UrlEncode(this.errorLanguage, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			return sb.ToString();
		}

	}


	/**
	 * Describes the request for permissions over an
	 * account. Primary element is "scope", which lists
	 * the permissions needed.
	 */
	public partial class RequestPermissionsRequest {

		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope {
			get {
				return this.requestEnvelopeField;
			}
			set {
				this.requestEnvelopeField = value;
			}
		}

		/**
		 * URI of the permissions being requested.
		 */
		private List<string> scopeField = new List<string>();
		public List<string> scope {
			get {
				return this.scopeField;
			}
			set {
				this.scopeField = value;
			}
		}

		/**
		 * URL on the client side that will be used
		 * to communicate completion of the user
		 * flow. The URL can include query
		 * parameters.
		 */
		private string callbackField;
		public string callback {
			get {
				return this.callbackField;
			}
			set {
				this.callbackField = value;
			}
		}

		public RequestPermissionsRequest(List<string> scope, string callback) {
			this.scope = scope;
			this.callback = callback;
		}
		public RequestPermissionsRequest() {
		}
		public string toNVPString(string prefix) {
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null) {
				string newPrefix = prefix + "requestEnvelope" + '.';
				sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			for (int i = 0; i < this.scope.Count; i++) {
				if (this.scope[i] != null) {
					sb.Append(prefix).Append("scope").Append('(').Append(i).Append(')').Append('=').Append(HttpUtility.UrlEncode(this.scope[i], BaseConstants.ENCODING_FORMAT)).Append('&');
				}
			}
			if (this.callback != null) {
				sb.Append(prefix).Append("callback").Append('=').Append(HttpUtility.UrlEncode(this.callback, BaseConstants.ENCODING_FORMAT)).Append('&');
			}
			return sb.ToString();
		}

	}


	/**
	 * Returns the temporary request token
	 */
	public partial class RequestPermissionsResponse {

		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope {
			get {
				return this.responseEnvelopeField;
			}
			set {
				this.responseEnvelopeField = value;
			}
		}

		/**
		 * Temporary token that identifies the
		 * request for permissions. This token
		 * cannot be used to access resources on
		 * the account. It can only be used to
		 * instruct the user to authorize the
		 * permissions.
		 */
		private string tokenField;
		public string token {
			get {
				return this.tokenField;
			}
			set {
				this.tokenField = value;
			}
		}

		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error {
			get {
				return this.errorField;
			}
			set {
				this.errorField = value;
			}
		}

	 public RequestPermissionsResponse(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if (map.ContainsKey(key + ".timestamp")) {
				this.responseEnvelope = new ResponseEnvelope(map, key + '.');
			}
			key = prefix + "token";
			if (map.ContainsKey(key)) {
				this.token = map[key];
			}
			i = 0;
			while(true) {
				key = prefix + "error" + '(' + i + ")";
				if (map.ContainsKey(key + ".errorId")) {
					this.error.Add( new ErrorData(map, key + '.')); 
				}
				else break;
				i++;
			}
		}
	}


	/**
	 * This is the sample message
	 */
	public partial class ResponseEnvelope {

		private string timestampField;
		public string timestamp {
			get {
				return this.timestampField;
			}
			set {
				this.timestampField = value;
			}
		}

		/**
		 * Application level acknowledgment code.
		 */
		private AckCode? ackField;
		public AckCode? ack {
			get {
				return this.ackField;
			}
			set {
				this.ackField = value;
			}
		}

		private string correlationIdField;
		public string correlationId {
			get {
				return this.correlationIdField;
			}
			set {
				this.correlationIdField = value;
			}
		}

		private string buildField;
		public string build {
			get {
				return this.buildField;
			}
			set {
				this.buildField = value;
			}
		}

	 public ResponseEnvelope(Dictionary<string, string> map, string prefix) {
			string key = "";
			int i;
			key = prefix + "timestamp";
			if (map.ContainsKey(key)) {
				this.timestamp = map[key];
			}
			key = prefix + "ack";
			if (map.ContainsKey(key)) {
				this.ack = (AckCode)EnumUtils.getValue(map[key],typeof(AckCode));;
			}
			key = prefix + "correlationId";
			if (map.ContainsKey(key)) {
				this.correlationId = map[key];
			}
			key = prefix + "build";
			if (map.ContainsKey(key)) {
				this.build = map[key];
			}
		}
	}


}
