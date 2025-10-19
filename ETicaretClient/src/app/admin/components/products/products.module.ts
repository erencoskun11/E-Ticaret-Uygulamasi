// src/app/components/products/products.module.ts
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ProductsComponent } from './products.component'; // Standalone component

@NgModule({
  imports: [
    ProductsComponent, // ✅ Standalone olduğu için declare etmeye gerek yok
    RouterModule.forChild([
      { path: "", component: ProductsComponent } // Lazy-load route
    ])
  ]
})
export class ProductsModule {}
