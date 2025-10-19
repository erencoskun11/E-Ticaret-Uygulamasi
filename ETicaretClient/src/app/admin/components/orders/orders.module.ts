// src/app/components/orders/orders.module.ts
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { OrdersComponent } from './orders.component'; // Standalone component

@NgModule({
  imports: [
    OrdersComponent, // ✅ Standalone olduğu için declarations gerek yok
    RouterModule.forChild([
      { path: "", component: OrdersComponent } // Lazy-load route
    ])
  ]
})
export class OrdersModule {}
