// src/app/components/dashboard/dashboard.component.ts
import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-dashboard',
  standalone: true,     // ✅ Standalone component
  imports: [CommonModule], // Component'in kullandığı modüller
  templateUrl: './dashboard.component.html'
})
export class DashboardComponent {}
