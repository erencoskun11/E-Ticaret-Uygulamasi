
// src/app/admin/layout/layout.module.ts
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { LayoutComponent } from './layout.component';
import { ComponentsModule } from './components/components.module';

@NgModule({
  declarations: [
    LayoutComponent
  ],
  imports: [
    CommonModule,
    RouterModule,   
    ComponentsModule
  ],
  exports: [
    LayoutComponent
  ]
})
export class LayoutModule {}
