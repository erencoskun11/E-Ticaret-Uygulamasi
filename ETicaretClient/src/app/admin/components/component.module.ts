// src/app/components/component.module.ts
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductsModule } from './products/products.module';
import { OrdersModule } from './orders/orders.module';
import { CustomersModule } from './customers/customers.module';
import { DashboardModule } from './dashboard/dashboard.module';

@NgModule({
  imports: [
    CommonModule,
    ProductsModule,   // Lazy-load modüller
    OrdersModule,
    CustomersModule,
    DashboardModule
  ]
})
export class ComponentModule {}
