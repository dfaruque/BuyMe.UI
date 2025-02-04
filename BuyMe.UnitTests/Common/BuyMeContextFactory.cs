﻿using BuyMe.Application.Common.Interfaces;
using BuyMe.Application.Common.Models;
using BuyMe.Domain.Entities;
using BuyMe.Persistence;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;

namespace BuyMe.UnitTests.Common
{
    public class BuyMeContextFactory
    {
        public static BuyMeDbContext Create()
        {
            var options = new DbContextOptionsBuilder<BuyMeDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            var context = new BuyMeDbContext(options, new Mock<ITenantService>().Object, new Mock<ICurrentUserService>().Object);
            context.Database.EnsureCreated();
            SeedCompanyData(context);
            SeedShipmentData(context);
            SeedInvoiceTypeData(context);
            SeedInvoiceData(context);
            SeedCustomFieldAndData(context);
            SeedPaymentTypeData(context);
            SeedPaymentReceiveData(context);
            SeedVendorTypesData(context);
            SeedVendorsData(context);
            SeedPurchasTypeData(context);
            SeedBrachesData(context);
            SeedCategoriesData(context);
            SeedCustmerData(context);
            SeedSalesTypeData(context);
            SeedWarehouseData(context);
            SeedCurrencyData(context);
            SeedCustomerTypeData(context);
            SeedEmployeeData(context);
            SeedUOMData(context);
            SeedSalesOrderData(context);
            context.SaveChanges();
            return context;
        }

        private static void SeedSalesOrderData(BuyMeDbContext context)
        {
            context.SalesOrders.AddRange(new () { SalesOrderName = "00000#1"},
                new () { SalesOrderName = "00000#2"});
        }

        private static void SeedEmployeeData(BuyMeDbContext context)
        {
            context.Employees.AddRange(new () { FirstName = "firstName",LastName = "lastName"},
                new () { FirstName = "firstName2",LastName = "lastName2"});
        }

        private static void SeedUOMData(BuyMeDbContext context)
        {
            context.UnitOfMeasures.AddRange(new () { UOM = "UOM4"}, new () { UOM = "UOM35"});
        }

        private static void SeedCustomerTypeData(BuyMeDbContext context)
        {
            context.CustomerTypes.AddRange(new CustomerType() { CustomerTypeName = "CustomerType4"},
                new CustomerType { CustomerTypeName = "CustomerType35"});
        }

        private static void SeedCurrencyData(BuyMeDbContext context)
        {
            context.Currencies.AddRange(new Currency() { CurrencyName = "Curriency4"},
                new Currency { CurrencyName = "Curriency35"});
        }

        private static void SeedWarehouseData(BuyMeDbContext context)
        {
            context.Warehouses.AddRange(new Warehouse() { WarehouseName = "Warehouse4"},
                new Warehouse { WarehouseName = "Warehouse35"});
        }

        private static void SeedSalesTypeData(BuyMeDbContext context)
        {
            context.SalesTypes.AddRange(new SalesType() { SalesTypeName = "SalesType4"},
                new SalesType { SalesTypeName = "SalesType35"});
        }

        private static void SeedCustmerData(BuyMeDbContext context)
        {
            context.Customers.AddRange(new Customer { CustomerName = "Cust4"},
                new Customer { CustomerName = "Cust35"});
        }

        private static void SeedCategoriesData(BuyMeDbContext context)
        {
            context.Categories.AddRange(new Category { CategoryName = "Categ4"},
                          new Category { CategoryName = "Categ35"});
        }

        private static void SeedBrachesData(BuyMeDbContext context)
        {
            context.Branches.AddRange(new  Branch{ BranchName = "Branch4", Address = "Address" },
                          new Branch { BranchName = "Branch35", Address = "Address" });
        }

        private static void SeedPurchasTypeData(BuyMeDbContext context)
        {
            context.PurchaseTypes.AddRange(new ("PurchType4","PayDes"),
                           new  ("PurchType35","PayDes3"));
        }

        private static void SeedVendorsData(BuyMeDbContext context)
        {
            context.Vendors.AddRange(new Vendor { Name = "Vend4", Address = "Address" },
                          new Vendor { Name = "Vend35", Address = "Address" });
        }

        private static void SeedVendorTypesData(BuyMeDbContext context)
        {
            context.VendorTypes.AddRange(new VendorType { Name = "VendType4", Description = "PayDes" },
                           new VendorType { Name = "VendType35", Description = "PayDes3" });
        }

        private static void SeedPaymentTypeData(BuyMeDbContext context)
        {
            context.PaymentTypes.AddRange(new PaymentType { PaymentTypeName = "Pay4", Description = "PayDes" },
                           new PaymentType { PaymentTypeName = "Pay35", Description = "PayDes3" });
        }

        private static void SeedInvoiceTypeData(BuyMeDbContext context)
        {
            context.InvoiceTypes.AddRange(new InvoiceType { InvoiceTypeName = "Inv34", Description = "InvDes" },
                            new InvoiceType { InvoiceTypeName = "Inv35", Description = "InvDes3" });
        }

        private static void SeedCompanyData(BuyMeDbContext context)
        {
            context.Companies.AddRange(new Company { Name = "CompanyOne" }, new Company() { Name = "CompanyTwo" });
        }

        private static void SeedInvoiceData(BuyMeDbContext context)
        {
            
            context.Invoices.AddRange(new Invoice
            {
                InvoiceName = "00001#INV",
                ShipmentId = 1,
                InvoiceTypeId = 1
            },
            new Invoice()
            {
                InvoiceName = "00002#INV",
                ShipmentId = 2,
                InvoiceTypeId = 2
            }, new Invoice()
            {
                InvoiceName = "00003#INV",
                ShipmentId = 1,
                InvoiceTypeId = 1
            }
            );
        }
        private static void SeedPaymentReceiveData(BuyMeDbContext context)
        {

            context.PaymentReceives.AddRange(new PaymentReceive
            {
                PaymentReceiveName = "00001#PAYRCV",
                PaymentTypeId = 1,
                InvoiceId = 1
            },
            new PaymentReceive()
            {
                PaymentReceiveName = "00002#PAYRCV",
                PaymentTypeId = 2,
                InvoiceId = 2
            }, new PaymentReceive()
            {
                PaymentReceiveName = "00003#PAYRCV",
                PaymentTypeId = 1,
                InvoiceId = 1
            }
            );
        }
        private static void SeedShipmentData(BuyMeDbContext context)
        {
            context.Shipments.AddRange(new Shipment()
            {
                CompanyId = 1,
                ShipmentName = "00001#ship"
            }, new Shipment()
            {
                CompanyId = 1,
                ShipmentName = "00002#ship"
            });
        }

        private static void SeedCustomFieldAndData(BuyMeDbContext context)
        {
            context.CustomFields.AddRange(new CustomField()
            {
                FieldName = "CustomNameOne",
                FieldType = "Text",
                Category = CustomCategoryModel.Product,
                CompanyId = 1
            }, new CustomField()
            {
                FieldName = "CustomNameTwo",
                FieldType = "Text",
                Category = CustomCategoryModel.Product,
                CompanyId = 1
            }, new CustomField()
            {
                FieldName = "CustomNameThree",
                FieldType = "Text",
                Category = CustomCategoryModel.Product,
                CompanyId = 1
            });
            context.CustomFieldDatas.AddRange(
                new CustomFieldData()
                {
                    RefranceId = 1,
                    Category = CustomCategoryModel.Product,
                    Value = "[{'FieldName':'CustomNameOne','FieldValue':'#b03636'}]",
                    CompanyId = 1
                },
            new CustomFieldData()
            {
                RefranceId = 2,
                Category = CustomCategoryModel.Product,
                Value = "[{'FieldName':'CustomNameOne','FieldValue':'#b09636'}]",
                CompanyId = 1
            }
            , new CustomFieldData()
            {
                RefranceId = 3,
                Category = CustomCategoryModel.Product,
                Value = "[{'FieldName':'CustomNameOne','FieldValue':'#b09636'},{'FieldName':'CustomNameTwo','FieldValue':'#b09636'}]",
                CompanyId = 1
            });
        }

        public static void Destroy(BuyMeDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }
    }
}