import { ApplicationConfig, importProvidersFrom } from '@angular/core';
import { provideRouter } from '@angular/router';
import { provideClientHydration } from '@angular/platform-browser';
import { routes } from './app.routes';

// Feature modüllerini import et
import { AdminModule } from './admin/admin.module';
import { UiModule } from './ui/ui.module';

export const appConfig: ApplicationConfig = {
  providers: [
    provideRouter(routes),           // root router yalnızca burada
    provideClientHydration(),        // SSR/rehydration için
    importProvidersFrom(AdminModule, UiModule)  // modüller burada import edildi
  ]
};

