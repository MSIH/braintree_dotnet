#pragma warning disable 1591

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Braintree
{
    public enum TransactionGatewayRejectionReason
    {
        [Description("application_incomplete")] APPLICATION_INCOMPLETE,
        [Description("avs")] AVS,
        [Description("avs_and_cvv")] AVS_AND_CVV,
        [Description("cvv")] CVV,
        [Description("duplicate")] DUPLICATE,
        [Description("fraud")] FRAUD,
        [Description("risk_threshold")] RISK_THRESHOLD,
        [Description("three_d_secure")] THREE_D_SECURE,
        [Description("token_issuance")] TOKEN_ISSUANCE,
        [Description("unrecognized")] UNRECOGNIZED
    }

    public enum TransactionEscrowStatus
    {
        [Description("hold_pending")] HOLD_PENDING,
        [Description("held")] HELD,
        [Description("release_pending")] RELEASE_PENDING,
        [Description("released")] RELEASED,
        [Description("refunded")] REFUNDED,
        [Description("unrecognized")] UNRECOGNIZED
    }

    public enum TransactionStatus
    {
        [Description("authorization_expired")] AUTHORIZATION_EXPIRED,
        [Description("authorized")] AUTHORIZED,
        [Description("authorizing")] AUTHORIZING,
        [Description("failed")] FAILED,
        [Description("gateway_rejected")] GATEWAY_REJECTED,
        [Description("processor_declined")] PROCESSOR_DECLINED,
        [Description("settled")] SETTLED,
        [Description("settling")] SETTLING,
        [Description("submitted_for_settlement")] SUBMITTED_FOR_SETTLEMENT,
        [Description("voided")] VOIDED,
        [Description("unrecognized")] UNRECOGNIZED,
        [Description("settlement_confirmed")] SETTLEMENT_CONFIRMED,
        [Description("settlement_declined")] SETTLEMENT_DECLINED,
        [Description("settlement_pending")] SETTLEMENT_PENDING
    }

    public enum TransactionIndustryType
    {
        [Description("lodging")] LODGING,
        [Description("travel_cruise")] TRAVEL_AND_CRUISE,
        [Description("travel_flight")] TRAVEL_AND_FLIGHT
    }

    public enum TransactionSource
    {
        [Description("api")] API,
        [Description("control_panel")] CONTROL_PANEL,
        [Description("recurring")] RECURRING,
        [Description("unrecognized")] UNRECOGNIZED
    }

    public enum TransactionType
    {
        [Description("credit")] CREDIT,
        [Description("sale")] SALE,
        [Description("unrecognized")] UNRECOGNIZED
    }

    public enum TransactionCreatedUsing
    {
        [Description("full_information")] FULL_INFORMATION,
        [Description("token")] TOKEN,
        [Description("unrecognized")] UNRECOGNIZED
    }

    public enum PaymentInstrumentType
    {
        [Description("paypal_account")] PAYPAL_ACCOUNT,
        [Description("paypal_here")] PAYPAL_HERE,
        [Description("credit_card")] CREDIT_CARD,
        [Description("apple_pay_card")] APPLE_PAY_CARD,
        [Description("android_pay_card")] ANDROID_PAY_CARD,
        [Description("amex_express_checkout_card")] AMEX_EXPRESS_CHECKOUT_CARD,
        [Description("venmo_account")] VENMO_ACCOUNT,
        [Description("us_bank_account")] US_BANK_ACCOUNT,
        [Description("visa_checkout_card")] VISA_CHECKOUT_CARD,
        [Description("samsung_pay_card")] SAMSUNG_PAY_CARD,
        [Description("local_payment")] LOCAL_PAYMENT,
        [Description("any")] ANY,
        [Description("unknown")] UNKNOWN
    }

    /// <summary>
    /// A transaction returned by the Braintree Gateway
    /// </summary>
    /// <example>
    /// Transactions can be retrieved via the gateway using the associated transaction id:
    /// <code>
    ///     Transaction transaction = gateway.Transaction.Find("transactionId");
    /// </code>
    /// For more information about Transactions, see <a href="https://developer.paypal.com/braintree/docs/reference/response/transaction/dotnet" target="_blank">https://developer.paypal.com/braintree/docs/reference/response/transaction/dotnet</a>
    /// </example>
    public class Transaction
    {
        public virtual string Id { get; protected set; }
        public virtual List<AddOn> AddOns { get; protected set; }
        public virtual decimal? Amount { get; protected set; }
        public virtual string AvsErrorResponseCode { get; protected set; }
        public virtual string AvsPostalCodeResponseCode { get; protected set; }
        public virtual string AvsStreetAddressResponseCode { get; protected set; }
        public virtual Address BillingAddress { get; protected set; }
        public virtual string Channel { get; protected set; }
        public virtual DateTime? CreatedAt { get; protected set; }
        public virtual CreditCard CreditCard { get; protected set; }
        public virtual string CurrencyIsoCode { get; protected set; }
        public virtual CustomerDetails CustomerDetails { get; protected set; }
        public virtual string CvvResponseCode { get; protected set; }
        public virtual Descriptor Descriptor { get; protected set; }
        public virtual List<Discount> Discounts { get; protected set; }
        public virtual List<Dispute> Disputes { get; protected set; }
        public virtual TransactionGatewayRejectionReason GatewayRejectionReason { get; protected set; }
        public virtual string GraphQLId { get; protected set; }
        public virtual string MerchantAccountId { get; protected set; }
        public virtual string OrderId { get; protected set; }
        public virtual string PlanId { get; protected set; }
        public virtual bool? ProcessedWithNetworkToken { get; protected set; }
        public virtual string ProcessorAuthorizationCode { get; protected set; }
        public virtual ProcessorResponseType ProcessorResponseType { get; protected set; }
        public virtual string ProcessorResponseCode { get; protected set; }
        public virtual string ProcessorResponseText { get; protected set; }
        public virtual string ProcessorSettlementResponseCode { get; protected set; }
        public virtual string ProcessorSettlementResponseText { get; protected set; }
        public virtual string AdditionalProcessorResponse { get; protected set; }
        public virtual string NetworkResponseCode { get; protected set; }
        public virtual string NetworkResponseText { get; protected set; }
        public virtual string VoiceReferralNumber { get; protected set; }
        public virtual string PurchaseOrderNumber { get; protected set; }
        public virtual bool? Recurring { get; protected set; }
        public virtual string RefundedTransactionId { get; protected set; }
        public virtual List<string> RefundIds { get; protected set; }
        public virtual List<string> PartialSettlementTransactionIds { get; protected set; }
        public virtual string AuthorizedTransactionId { get; protected set; }
        public virtual string SettlementBatchId { get; protected set; }
        public virtual Address ShippingAddress { get; protected set; }
        public virtual TransactionEscrowStatus EscrowStatus { get; protected set; }
        public virtual TransactionStatus Status { get; protected set; }
        public virtual StatusEvent[] StatusHistory { get; protected set; }
        public virtual List<AuthorizationAdjustment> AuthorizationAdjustments { get; protected set; }
        public virtual string SubscriptionId { get; protected set; }
        public virtual SubscriptionDetails SubscriptionDetails { get; protected set; }
        public virtual decimal? TaxAmount { get; protected set; }
        public virtual bool? TaxExempt { get; protected set; }
        public virtual TransactionType Type { get; protected set; }
        public virtual DateTime? UpdatedAt { get; protected set; }
        public virtual Dictionary<string, string> CustomFields { get; protected set; }
        public virtual decimal? ServiceFeeAmount { get; protected set; }
        public virtual DisbursementDetails DisbursementDetails { get; protected set; }
        public virtual ApplePayDetails ApplePayDetails { get; protected set; }
        public virtual AndroidPayDetails AndroidPayDetails { get; protected set; }
        public virtual PayPalDetails PayPalDetails { get; protected set; }
        public virtual PayPalHereDetails PayPalHereDetails { get; protected set; }
        public virtual LocalPaymentDetails LocalPaymentDetails { get; protected set; }
        public virtual VenmoAccountDetails VenmoAccountDetails { get; protected set; }
        public virtual UsBankAccountDetails UsBankAccountDetails { get; protected set; }
        public virtual VisaCheckoutCardDetails VisaCheckoutCardDetails { get; protected set; }
        public virtual SamsungPayCardDetails SamsungPayCardDetails { get; protected set; }
        public virtual PaymentInstrumentType PaymentInstrumentType { get; protected set; }
        public virtual RiskData RiskData { get; protected set; }
        public virtual ThreeDSecureInfo ThreeDSecureInfo { get; protected set; }
        public virtual FacilitatedDetails FacilitatedDetails { get; protected set; }
        public virtual FacilitatorDetails FacilitatorDetails { get; protected set; }
        public virtual string ScaExemptionRequested { get; protected set; }
        public virtual decimal? DiscountAmount { get; protected set; }
        public virtual decimal? ShippingAmount { get; protected set; }
        public virtual string ShipsFromPostalCode { get; protected set; }
        public virtual string NetworkTransactionId { get; protected set; }
        public virtual DateTime? AuthorizationExpiresAt { get; protected set; }
        public virtual string RetrievalReferenceNumber { get; protected set; }
        public virtual string AcquirerReferenceNumber { get; protected set; }
        public virtual decimal? InstallmentCount { get; protected set; }
        public virtual List<Installment> Installments { get; protected set; }
        public virtual List<Installment> RefundedInstallments { get; protected set; }

        private IBraintreeGateway Gateway;

        [Obsolete("Mock Use Only")]
        protected Transaction() { }

        protected internal Transaction(NodeWrapper node, IBraintreeGateway gateway)
        {
            Gateway = gateway;

            if (node == null)
                return;

            Id = node.GetString("id");
            Amount = node.GetDecimal("amount");
            AvsErrorResponseCode = node.GetString("avs-error-response-code");
            AvsPostalCodeResponseCode = node.GetString("avs-postal-code-response-code");
            AvsStreetAddressResponseCode = node.GetString("avs-street-address-response-code");
            GatewayRejectionReason = node.GetEnum("gateway-rejection-reason", TransactionGatewayRejectionReason.UNRECOGNIZED);
            PaymentInstrumentType = node.GetEnum("payment-instrument-type", PaymentInstrumentType.UNKNOWN);
            Channel = node.GetString("channel");
            GraphQLId = node.GetString("global-id");
            OrderId = node.GetString("order-id");
            Status = node.GetEnum("status", TransactionStatus.UNRECOGNIZED);
            EscrowStatus = node.GetEnum("escrow-status", TransactionEscrowStatus.UNRECOGNIZED);

            List<NodeWrapper> statusNodes = node.GetList("status-history/status-event");
            StatusHistory = new StatusEvent[statusNodes.Count];
            for (int i = 0; i < statusNodes.Count; i++)
            {
                StatusHistory[i] = new StatusEvent(statusNodes[i]);
            }

            Type = node.GetEnum("type", TransactionType.UNRECOGNIZED);
            ScaExemptionRequested = node.GetString("sca-exemption-requested");
            MerchantAccountId = node.GetString("merchant-account-id");
            ProcessedWithNetworkToken = node.GetBoolean("processed-with-network-token");
            ProcessorAuthorizationCode = node.GetString("processor-authorization-code");
            ProcessorResponseCode = node.GetString("processor-response-code");
            ProcessorResponseText = node.GetString("processor-response-text");
            ProcessorResponseType = node.GetEnum("processor-response-type", ProcessorResponseType.UNRECOGNIZED);
            ProcessorSettlementResponseCode = node.GetString("processor-settlement-response-code");
            ProcessorSettlementResponseText = node.GetString("processor-settlement-response-text");
            NetworkResponseCode = node.GetString("network-response-code");
            NetworkResponseText = node.GetString("network-response-text");
            AdditionalProcessorResponse = node.GetString("additional-processor-response");
            VoiceReferralNumber = node.GetString("voice-referral-number");
            PurchaseOrderNumber = node.GetString("purchase-order-number");
            Recurring = node.GetBoolean("recurring");
            RefundedTransactionId = node.GetString("refunded-transaction-id");

            RefundIds = node.GetStrings("refund-ids/*");
            PartialSettlementTransactionIds = node.GetStrings("partial-settlement-transaction-ids/*");
            AuthorizedTransactionId = node.GetString("authorized-transaction-id");
            SettlementBatchId = node.GetString("settlement-batch-id");
            PlanId = node.GetString("plan-id");
            SubscriptionId = node.GetString("subscription-id");
            TaxAmount = node.GetDecimal("tax-amount");
            TaxExempt = node.GetBoolean("tax-exempt");
            CustomFields = node.GetDictionary("custom-fields");
            var creditCardNode = node.GetNode("credit-card");
            if (creditCardNode != null)
            {
                CreditCard = new CreditCard(creditCardNode, gateway);
            }
            var subscriptionNode = node.GetNode("subscription");
            if (subscriptionNode != null)
            {
                SubscriptionDetails = new SubscriptionDetails(subscriptionNode);
            }
            var customerNode = node.GetNode("customer");
            if (customerNode != null)
            {
                CustomerDetails = new CustomerDetails(customerNode, gateway);
            }
            CurrencyIsoCode = node.GetString("currency-iso-code");
            CvvResponseCode = node.GetString("cvv-response-code");
            var descriptorNode = node.GetNode("descriptor");
            if (descriptorNode != null)
            {
                Descriptor = new Descriptor(descriptorNode);
            }
            ServiceFeeAmount = node.GetDecimal("service-fee-amount");
            var disbursementDetailsNode = node.GetNode("disbursement-details");
            if (disbursementDetailsNode != null)
            {
                DisbursementDetails = new DisbursementDetails(disbursementDetailsNode);
            }
            var paypalNode = node.GetNode("paypal");
            if (paypalNode != null)
            {
                PayPalDetails = new PayPalDetails(paypalNode);
            }
            var paypalHereNode = node.GetNode("paypal-here");
            if (paypalHereNode != null)
            {
                PayPalHereDetails = new PayPalHereDetails(paypalHereNode);
            }
            var localPaymentNode = node.GetNode("local-payment");
            if (localPaymentNode != null)
            {
                LocalPaymentDetails = new LocalPaymentDetails(localPaymentNode);
            }
            var applePayNode = node.GetNode("apple-pay");
            if (applePayNode != null)
            {
                ApplePayDetails = new ApplePayDetails(applePayNode);
            }
            var androidPayNode = node.GetNode("android-pay-card");
            if (androidPayNode != null)
            {
                AndroidPayDetails = new AndroidPayDetails(androidPayNode);
            }
            var venmoAccountNode = node.GetNode("venmo-account");
            if (venmoAccountNode != null)
            {
                VenmoAccountDetails = new VenmoAccountDetails(venmoAccountNode);
            }
            var usBankAccountNode = node.GetNode("us-bank-account");
            if (usBankAccountNode != null)
            {
                UsBankAccountDetails = new UsBankAccountDetails(usBankAccountNode);
            }
            var visaCheckoutNode = node.GetNode("visa-checkout-card");
            if (visaCheckoutNode != null)
            {
                VisaCheckoutCardDetails = new VisaCheckoutCardDetails(visaCheckoutNode);
            }
            var samsungPayNode = node.GetNode("samsung-pay-card");
            if (samsungPayNode != null)
            {
                SamsungPayCardDetails = new SamsungPayCardDetails(samsungPayNode);
            }

            var billingAddressNode = node.GetNode("billing");
            if (billingAddressNode != null)
            {
                BillingAddress = new Address(billingAddressNode);
            }
            var shippingAddressNode = node.GetNode("shipping");
            if (shippingAddressNode != null)
            {
                ShippingAddress = new Address(shippingAddressNode);
            }

            CreatedAt = node.GetDateTime("created-at");
            UpdatedAt = node.GetDateTime("updated-at");

            AddOns = new List<AddOn>();
            foreach (var addOnResponse in node.GetList("add-ons/add-on"))
            {
                AddOns.Add(new AddOn(addOnResponse));
            }
            Discounts = new List<Discount>();
            foreach (var discountResponse in node.GetList("discounts/discount"))
            {
                Discounts.Add(new Discount(discountResponse));
            }

            Disputes = new List<Dispute>();
            foreach (var dispute in node.GetList("disputes/dispute"))
            {
                Disputes.Add(new Dispute(dispute));
            }

            AuthorizationAdjustments = new List<AuthorizationAdjustment>();
            foreach (var authorizationAdjustment in node.GetList("authorization-adjustments/authorization-adjustment"))
            {
                AuthorizationAdjustments.Add(new AuthorizationAdjustment(authorizationAdjustment));
            }

            var riskDataNode = node.GetNode("risk-data");
            if (riskDataNode != null)
            {
                RiskData = new RiskData(riskDataNode);
            }

            var threeDSecureInfoNode = node.GetNode("three-d-secure-info");
            if (threeDSecureInfoNode != null && !threeDSecureInfoNode.IsEmpty())
            {
                ThreeDSecureInfo = new ThreeDSecureInfo(threeDSecureInfoNode);
            }

            var facilitatedDetailsNode = node.GetNode("facilitated-details");
            if (facilitatedDetailsNode != null && !facilitatedDetailsNode.IsEmpty())
            {
                FacilitatedDetails = new FacilitatedDetails(facilitatedDetailsNode);
            }

            var facilitatorDetailsNode = node.GetNode("facilitator-details");
            if (facilitatorDetailsNode != null && !facilitatorDetailsNode.IsEmpty())
            {
                FacilitatorDetails = new FacilitatorDetails(facilitatorDetailsNode);
            }

            DiscountAmount = node.GetDecimal("discount-amount");
            ShippingAmount = node.GetDecimal("shipping-amount");
            ShipsFromPostalCode = node.GetString("ships-from-postal-code");

            NetworkTransactionId = node.GetString("network-transaction-id");

            AuthorizationExpiresAt = node.GetDateTime("authorization-expires-at");

            RetrievalReferenceNumber = node.GetString("retrieval-reference-number");

            AcquirerReferenceNumber = node.GetString("acquirer-reference-number");

            InstallmentCount = node.GetDecimal("installment-count");
            
            Installments = new List<Installment>();
            foreach (var installment in node.GetList("installments/installment"))
            {
                Installments.Add(new Installment(installment));
            }

            RefundedInstallments = new List<Installment>();
            foreach (var installment in node.GetList("refunded-installments/refunded-installment"))
            {
                RefundedInstallments.Add(new Installment(installment));
            }
        }

        /// <summary>
        /// Returns the current <see cref="CreditCard"/> associated with this transaction if one exists
        /// </summary>
        /// <returns>
        /// The current <see cref="CreditCard"/> associated with this transaction if one exists
        /// </returns>
        /// <remarks>
        /// When retrieving a transaction from the gateway, the credit card used in the transaction is returned in the response.
        /// If the credit card record has been updated in the vault since the transaction occurred, this method can be used to
        /// retrieve the updated credit card information.  This is typically useful in situations where a transaction fails, for
        /// example when a credit card expires, and a new transaction needs to be submitted once the new credit card information
        /// has been submitted.
        /// </remarks>
        /// <example>
        /// The vault <see cref="CreditCard"/> can be retrieved from the transaction directly:
        /// <code>
        ///     Transaction transaction = gateway.Transaction.Find("transactionId");
        ///     CreditCard creditCard = transaction.GetVaultCreditCard();
        /// </code>
        /// </example>
        /// <example>
        /// Failed transactions can be resubmitted with updated <see cref="CreditCard"/> information:
        /// <code>
        ///     Transaction failedTransaction = gateway.Transaction.Find("transactionId");
        ///     CreditCard updatedCreditCard = transaction.GetVaultCreditCard();
        ///
        ///     TransactionRequest request = new TransactionRequest
        ///     {
        ///         Amount = failedTransaction.Amount,
        ///         PaymentMethodToken = updatedCreditCard.Token
        ///     };
        ///
        ///     Result&lt;Transaction&gt; result = gateway.Transaction.Sale(request);
        /// </code>
        /// </example>
        public virtual CreditCard GetVaultCreditCard()
        {
            if (CreditCard.Token == null) return null;

            return new CreditCardGateway(Gateway).Find(CreditCard.Token);
        }

        /// <summary>
        /// Returns the current <see cref="Customer"/> associated with this transaction if one exists
        /// </summary>
        /// <returns>
        /// The current <see cref="Customer"/> associated with this transaction if one exists
        /// </returns>
        /// <remarks>
        /// When retrieving a transaction from the gateway, the customer associated with the transaction is returned in the response.
        /// If the customer record has been updated in the vault since the transaction occurred, this method can be used to
        /// retrieve the updated customer information.
        /// </remarks>
        /// <example>
        /// The vault <see cref="Customer"/> can be retrieved from the transaction directly:
        /// <code>
        ///     Transaction transaction = gateway.Transaction.Find("transactionId");
        ///     Customer customer = transaction.GetVaultCustomer();
        /// </code>
        /// </example>
        public virtual Customer GetVaultCustomer()
        {
            if (CustomerDetails == null || CustomerDetails.Id == null) return null;

            return new CustomerGateway(Gateway).Find(CustomerDetails.Id);
        }

        /// <summary>
        /// Returns the current billing <see cref="Address"/> associated with this transaction if one exists
        /// </summary>
        /// <returns>
        /// The current billing <see cref="Address"/> associated with this transaction if one exists
        /// </returns>
        /// <remarks>
        /// When retrieving a transaction from the gateway, the billing address associated with the transaction is returned in the response.
        /// If the billing address has been updated in the vault since the transaction occurred, this method can be used to
        /// retrieve the updated billing address.
        /// </remarks>
        /// <example>
        /// The vault billing <see cref="Address"/> can be retrieved from the transaction directly:
        /// <code>
        ///     Transaction transaction = gateway.Transaction.Find("transactionId");
        ///     Address billingAddress = transaction.GetVaultBillingAddress();
        /// </code>
        /// </example>
        public virtual Address GetVaultBillingAddress()
        {
            if (BillingAddress.Id == null) return null;

            return new AddressGateway(Gateway).Find(CustomerDetails.Id, BillingAddress.Id);
        }

        /// <summary>
        /// Returns the current shipping <see cref="Address"/> associated with this transaction if one exists
        /// </summary>
        /// <returns>
        /// The current shipping <see cref="Address"/> associated with this transaction if one exists
        /// </returns>
        /// <remarks>
        /// When retrieving a transaction from the gateway, the shipping address associated with the transaction is returned in the response.
        /// If the shipping address has been updated in the vault since the transaction occurred, this method can be used to
        /// retrieve the updated shipping address.
        /// </remarks>
        /// <example>
        /// The vault shipping <see cref="Address"/> can be retrieved from the transaction directly:
        /// <code>
        ///     Transaction transaction = gateway.Transaction.Find("transactionId");
        ///     Address shippingAddress = transaction.GetVaultShippingAddress();
        /// </code>
        /// </example>
        public virtual Address GetVaultShippingAddress()
        {
            if (ShippingAddress.Id == null) return null;

            return new AddressGateway(Gateway).Find(CustomerDetails.Id, ShippingAddress.Id);
        }

        public bool IsDisbursed()
        {
          return DisbursementDetails.IsValid();
        }

        /// <summary>
        /// Returns the list of <see cref="TransactionLineItem"/>s associated with this transaction
        /// </summary>
        /// <returns>
        /// The list of <see cref="TransactionLineItem"/>s associated with this transaction
        /// </returns>
        /// <example>
        /// The list of <see cref="TransactionLineItem"/>s can be retrieved from the transaction directly:
        /// <code>
        ///     Transaction transaction = gateway.Transaction.Find("transactionId");
        ///     List&lt;TransactionLineItem&gt; lineItems = transaction.GetLineItems();
        /// </code>
        /// </example>
        public virtual List<TransactionLineItem> GetLineItems()
        {
            return Gateway.TransactionLineItem.FindAll(Id);
        }
    }
}
