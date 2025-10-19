import { Component } from '@angular/core';

@Component({
  selector: 'app-customers',
  standalone: true,
  imports: [],   // Buraya gerekiyorsa başka standalone componentleri veya modülleri ekleyebilirsin
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.scss'] // ✅ doğru
})
export class CustomersComponent {

}
