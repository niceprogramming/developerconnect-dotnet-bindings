/* 
 * Loan
 *
 * Returns the entire loan or specific entities of a loan.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Model;
using Elli.Api.Loans.Client;
using System.Reflection;

namespace Elli.Api.Loans.Test
{
    /// <summary>
    ///  Class for testing LoanContractLOCompensation
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LoanContractLOCompensationTests
    {
        // TODO uncomment below to declare an instance variable for LoanContractLOCompensation
        //private LoanContractLOCompensation instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LoanContractLOCompensation
            //instance = new LoanContractLOCompensation();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoanContractLOCompensation
        /// </summary>
        [Test]
        public void LoanContractLOCompensationInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LoanContractLOCompensation
            //Assert.IsInstanceOfType<LoanContractLOCompensation> (instance, "variable 'instance' is a LoanContractLOCompensation");
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'AdjustedPlanAdditonalAmountForBroker'
        /// </summary>
        [Test]
        public void AdjustedPlanAdditonalAmountForBrokerTest()
        {
            // TODO unit test for the property 'AdjustedPlanAdditonalAmountForBroker'
        }
        /// <summary>
        /// Test the property 'AdjustedPlanAdditonalAmountForOfficer'
        /// </summary>
        [Test]
        public void AdjustedPlanAdditonalAmountForOfficerTest()
        {
            // TODO unit test for the property 'AdjustedPlanAdditonalAmountForOfficer'
        }
        /// <summary>
        /// Test the property 'AdjustedPlanAmountForBroker'
        /// </summary>
        [Test]
        public void AdjustedPlanAmountForBrokerTest()
        {
            // TODO unit test for the property 'AdjustedPlanAmountForBroker'
        }
        /// <summary>
        /// Test the property 'AdjustedPlanAmountForOfficer'
        /// </summary>
        [Test]
        public void AdjustedPlanAmountForOfficerTest()
        {
            // TODO unit test for the property 'AdjustedPlanAmountForOfficer'
        }
        /// <summary>
        /// Test the property 'AdjustedPlanRateForBroker'
        /// </summary>
        [Test]
        public void AdjustedPlanRateForBrokerTest()
        {
            // TODO unit test for the property 'AdjustedPlanRateForBroker'
        }
        /// <summary>
        /// Test the property 'AdjustedPlanRateForOfficer'
        /// </summary>
        [Test]
        public void AdjustedPlanRateForOfficerTest()
        {
            // TODO unit test for the property 'AdjustedPlanRateForOfficer'
        }
        /// <summary>
        /// Test the property 'AdjustmentDescription'
        /// </summary>
        [Test]
        public void AdjustmentDescriptionTest()
        {
            // TODO unit test for the property 'AdjustmentDescription'
        }
        /// <summary>
        /// Test the property 'AdjustmentDescriptionForOfficer'
        /// </summary>
        [Test]
        public void AdjustmentDescriptionForOfficerTest()
        {
            // TODO unit test for the property 'AdjustmentDescriptionForOfficer'
        }
        /// <summary>
        /// Test the property 'BasePlanAdditonalAmountForBroker'
        /// </summary>
        [Test]
        public void BasePlanAdditonalAmountForBrokerTest()
        {
            // TODO unit test for the property 'BasePlanAdditonalAmountForBroker'
        }
        /// <summary>
        /// Test the property 'BasePlanAdditonalAmountForOfficer'
        /// </summary>
        [Test]
        public void BasePlanAdditonalAmountForOfficerTest()
        {
            // TODO unit test for the property 'BasePlanAdditonalAmountForOfficer'
        }
        /// <summary>
        /// Test the property 'BasePlanAmountForBroker'
        /// </summary>
        [Test]
        public void BasePlanAmountForBrokerTest()
        {
            // TODO unit test for the property 'BasePlanAmountForBroker'
        }
        /// <summary>
        /// Test the property 'BasePlanAmountForOfficer'
        /// </summary>
        [Test]
        public void BasePlanAmountForOfficerTest()
        {
            // TODO unit test for the property 'BasePlanAmountForOfficer'
        }
        /// <summary>
        /// Test the property 'BasePlanMaximumAmountForBroker'
        /// </summary>
        [Test]
        public void BasePlanMaximumAmountForBrokerTest()
        {
            // TODO unit test for the property 'BasePlanMaximumAmountForBroker'
        }
        /// <summary>
        /// Test the property 'BasePlanMaximumAmountForOfficer'
        /// </summary>
        [Test]
        public void BasePlanMaximumAmountForOfficerTest()
        {
            // TODO unit test for the property 'BasePlanMaximumAmountForOfficer'
        }
        /// <summary>
        /// Test the property 'BasePlanMinimumAmountForBroker'
        /// </summary>
        [Test]
        public void BasePlanMinimumAmountForBrokerTest()
        {
            // TODO unit test for the property 'BasePlanMinimumAmountForBroker'
        }
        /// <summary>
        /// Test the property 'BasePlanMinimumAmountForOfficer'
        /// </summary>
        [Test]
        public void BasePlanMinimumAmountForOfficerTest()
        {
            // TODO unit test for the property 'BasePlanMinimumAmountForOfficer'
        }
        /// <summary>
        /// Test the property 'BasePlanRateForBroker'
        /// </summary>
        [Test]
        public void BasePlanRateForBrokerTest()
        {
            // TODO unit test for the property 'BasePlanRateForBroker'
        }
        /// <summary>
        /// Test the property 'BasePlanRateForOfficer'
        /// </summary>
        [Test]
        public void BasePlanRateForOfficerTest()
        {
            // TODO unit test for the property 'BasePlanRateForOfficer'
        }
        /// <summary>
        /// Test the property 'BonusCompAdditonalAmount'
        /// </summary>
        [Test]
        public void BonusCompAdditonalAmountTest()
        {
            // TODO unit test for the property 'BonusCompAdditonalAmount'
        }
        /// <summary>
        /// Test the property 'BonusCompAmount'
        /// </summary>
        [Test]
        public void BonusCompAmountTest()
        {
            // TODO unit test for the property 'BonusCompAmount'
        }
        /// <summary>
        /// Test the property 'BonusCompRate'
        /// </summary>
        [Test]
        public void BonusCompRateTest()
        {
            // TODO unit test for the property 'BonusCompRate'
        }
        /// <summary>
        /// Test the property 'LastAppliedDate'
        /// </summary>
        [Test]
        public void LastAppliedDateTest()
        {
            // TODO unit test for the property 'LastAppliedDate'
        }
        /// <summary>
        /// Test the property 'LastAppliedDateTime'
        /// </summary>
        [Test]
        public void LastAppliedDateTimeTest()
        {
            // TODO unit test for the property 'LastAppliedDateTime'
        }
        /// <summary>
        /// Test the property 'LoanAmountType'
        /// </summary>
        [Test]
        public void LoanAmountTypeTest()
        {
            // TODO unit test for the property 'LoanAmountType'
        }
        /// <summary>
        /// Test the property 'LoanAmountTypeForOfficer'
        /// </summary>
        [Test]
        public void LoanAmountTypeForOfficerTest()
        {
            // TODO unit test for the property 'LoanAmountTypeForOfficer'
        }
        /// <summary>
        /// Test the property 'LoanOriginatorID'
        /// </summary>
        [Test]
        public void LoanOriginatorIDTest()
        {
            // TODO unit test for the property 'LoanOriginatorID'
        }
        /// <summary>
        /// Test the property 'LoanOriginatorIDForOfficer'
        /// </summary>
        [Test]
        public void LoanOriginatorIDForOfficerTest()
        {
            // TODO unit test for the property 'LoanOriginatorIDForOfficer'
        }
        /// <summary>
        /// Test the property 'LoanOriginatorName'
        /// </summary>
        [Test]
        public void LoanOriginatorNameTest()
        {
            // TODO unit test for the property 'LoanOriginatorName'
        }
        /// <summary>
        /// Test the property 'LoanOriginatorNameForOfficer'
        /// </summary>
        [Test]
        public void LoanOriginatorNameForOfficerTest()
        {
            // TODO unit test for the property 'LoanOriginatorNameForOfficer'
        }
        /// <summary>
        /// Test the property 'NetAdjustedAmountForBroker'
        /// </summary>
        [Test]
        public void NetAdjustedAmountForBrokerTest()
        {
            // TODO unit test for the property 'NetAdjustedAmountForBroker'
        }
        /// <summary>
        /// Test the property 'NetAdjustedAmountForOfficer'
        /// </summary>
        [Test]
        public void NetAdjustedAmountForOfficerTest()
        {
            // TODO unit test for the property 'NetAdjustedAmountForOfficer'
        }
        /// <summary>
        /// Test the property 'PlanDate'
        /// </summary>
        [Test]
        public void PlanDateTest()
        {
            // TODO unit test for the property 'PlanDate'
        }
        /// <summary>
        /// Test the property 'PlanName'
        /// </summary>
        [Test]
        public void PlanNameTest()
        {
            // TODO unit test for the property 'PlanName'
        }
        /// <summary>
        /// Test the property 'PlanNameForOfficer'
        /// </summary>
        [Test]
        public void PlanNameForOfficerTest()
        {
            // TODO unit test for the property 'PlanNameForOfficer'
        }
        /// <summary>
        /// Test the property 'RoundingMethod'
        /// </summary>
        [Test]
        public void RoundingMethodTest()
        {
            // TODO unit test for the property 'RoundingMethod'
        }
        /// <summary>
        /// Test the property 'RoundingMethodForOfficer'
        /// </summary>
        [Test]
        public void RoundingMethodForOfficerTest()
        {
            // TODO unit test for the property 'RoundingMethodForOfficer'
        }
        /// <summary>
        /// Test the property 'TriggerField'
        /// </summary>
        [Test]
        public void TriggerFieldTest()
        {
            // TODO unit test for the property 'TriggerField'
        }
        /// <summary>
        /// Test the property 'WhoPaidCompensation'
        /// </summary>
        [Test]
        public void WhoPaidCompensationTest()
        {
            // TODO unit test for the property 'WhoPaidCompensation'
        }

    }

}
