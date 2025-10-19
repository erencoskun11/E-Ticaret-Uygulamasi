import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-orders',
  standalone: true,       // ⚡ Standalone component olduğunu belirtiyor
  imports: [CommonModule], // Bu component içinde kullanacağın Angular modüller
  templateUrl: './orders.component.html',
  styleUrls: ['./orders.component.scss']
})
export class OrdersComponent {}
