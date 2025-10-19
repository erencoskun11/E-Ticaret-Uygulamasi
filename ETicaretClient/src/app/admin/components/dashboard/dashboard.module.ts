// src/app/components/dashboard/dashboard.module.ts
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard.component';

@NgModule({
  imports: [
    DashboardComponent, // ✅ Standalone component olarak import ediliyor
    RouterModule.forChild([
      { path: "", component: DashboardComponent } // Lazy-load route
    ])
  ]
})
export class DashboardModule {}
