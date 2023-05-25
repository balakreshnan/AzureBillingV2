﻿using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureBillingV2.Models
{
    public class BillingData //: ClassMap<BillingData>
    {
        public BillingData()
        {
            //Map(m => m.invoiceId);
            //Map(m => m.previousInvoiceId);
            //Map(m => m.billingAccountId);
            //Map(m => m.billingAccountName);
            //Map(m => m.billingProfileId);
            //Map(m => m.billingProfileName);
            //Map(m => m.invoiceSectionId);
            //Map(m => m.invoiceSectionName);
            //Map(m => m.resellerName);
            //Map(m => m.resellerMpnId);
            //Map(m => m.costCenter);
            //Map(m => m.billingPeriodEndDate);
            //Map(m => m.billingPeriodStartDate);
            //Map(m => m.servicePeriodEndDate);
            //Map(m => m.servicePeriodStartDate);
            //Map(m => m.date);
            //Map(m => m.serviceFamily);
            //Map(m => m.productOrderId);
            //Map(m => m.productOrderName);
            //Map(m => m.consumedService);
            //Map(m => m.meterId);
            //Map(m => m.meterName);
            //Map(m => m.meterCategory);
            //Map(m => m.meterSubCategory);
            //Map(m => m.meterRegion);
            //Map(m => m.ProductId);
            //Map(m => m.ProductName);
            //Map(m => m.SubscriptionId);
            //Map(m => m.subscriptionName);
            //Map(m => m.publisherType);
            //Map(m => m.publisherId);
            //Map(m => m.publisherName);
            //Map(m => m.resourceGroupName);
            //Map(m => m.ResourceId);
            //Map(m => m.resourceLocation);
            //Map(m => m.location);
            //Map(m => m.effectivePrice);
            //Map(m => m.quantity);
            //Map(m => m.unitOfMeasure);
            //Map(m => m.chargeType);
            //Map(m => m.billingCurrency);
            //Map(m => m.pricingCurrency);
            //Map(m => m.costInBillingCurrency);
            //Map(m => m.costInPricingCurrency);
            //Map(m => m.costInUsd);
            //Map(m => m.paygCostInBillingCurrency);
            //Map(m => m.paygCostInUsd);
            //Map(m => m.exchangeRatePricingToBilling);
            //Map(m => m.exchangeRateDate);
            //Map(m => m.isAzureCreditEligible);
            //Map(m => m.serviceInfo1);
            //Map(m => m.serviceInfo2);
            //Map(m => m.additionalInfo);
            //Map(m => m.tags);
            //Map(m => m.PayGPrice);
            //Map(m => m.frequency);
            //Map(m => m.term);
            //Map(m => m.reservationId);
            //Map(m => m.reservationName);
            //Map(m => m.pricingModel);
            //Map(m => m.unitPrice);
            //Map(m => m.costAllocationRuleName);
            //Map(m => m.benefitId);

        }
        public string invoiceId { get; set; } = "";
        public string previousInvoiceId { get; set; } = "";
        public string billingAccountId { get; set; } = "";
        public string billingAccountName { get; set; } = "";
        public string billingProfileId { get; set; } = "";
        public string billingProfileName { get; set; } = "";
        public string invoiceSectionId { get; set; } = "";
        public string invoiceSectionName { get; set; } = "";
        public string resellerName { get; set; } = "";
        public string resellerMpnId { get; set; } = "";
        public string costCenter { get; set; } = "";
        public string billingPeriodEndDate { get; set; } = "";
        public string billingPeriodStartDate { get; set; } = "";
        public string servicePeriodEndDate { get; set; } = "";
        public string servicePeriodStartDate { get; set; } = "";
        public string date { get; set; } = "";
        public string serviceFamily { get; set; } = "";
        public string productOrderId { get; set; } = "";
        public string productOrderName { get; set; } = "";
        public string consumedService { get; set; } = "";
        public string meterId { get; set; } = "";
        public string meterName { get; set; } = "";
        public string meterCategory { get; set; } = "";
        public string meterSubCategory { get; set; } = "";
        public string meterRegion { get; set; } = "";
        public string ProductId { get; set; } = "";
        public string ProductName { get; set; } = "";
        public string SubscriptionId { get; set; } = "";
        public string subscriptionName { get; set; } = "";
        public string publisherType { get; set; } = "";
        public string publisherId { get; set; } = "";
        public string publisherName { get; set; } = "";
        public string resourceGroupName { get; set; } = "";
        public string ResourceId { get; set; } = "";
        public string resourceLocation { get; set; } = "";
        public string location { get; set; } = "";
        public double effectivePrice { get; set; } = 0.0;
        public double quantity { get; set; } = 0.0;
        public string unitOfMeasure { get; set; } = "";
        public string chargeType { get; set; } = "";
        public string billingCurrency { get; set; } = "";
        public string pricingCurrency { get; set; } = "";
        public double costInBillingCurrency { get; set; } = 0.0;
        public double costInPricingCurrency { get; set; } = 0.0;
        public double costInUsd { get; set; } = -1.0;
        public double paygCostInBillingCurrency { get; set; } = 0.0;
        public double paygCostInUsd { get; set; } = 0.0;
        public double exchangeRatePricingToBilling { get; set; } = 0.0;
        public string exchangeRateDate { get; set; } = "";
        public string isAzureCreditEligible { get; set; } = "";
        public string serviceInfo1 { get; set; } = "";
        public string serviceInfo2 { get; set; } = "";
        public string additionalInfo { get; set; } = "";
        public string tags { get; set; } = "";
        public string PayGPrice { get; set; } = "";
        public string frequency { get; set; } = "";
        public string term { get; set; } = "";
        public string reservationId { get; set; } = "";
        public string reservationName { get; set; } = "";
        public string pricingModel { get; set; } = "";
        public double unitPrice { get; set; } = 0.0;
        public string costAllocationRuleName { get; set; } = "";
        public string benefitId { get; set; } = "";


    }
}