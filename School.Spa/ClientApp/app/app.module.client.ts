import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { sharedConfig } from './app.module.shared';
import { AuthHttp, JwtHelper, AUTH_PROVIDERS } from 'angular2-jwt';

import { AuthGuard } from './components/common/auth.guard';

@NgModule({
    bootstrap: sharedConfig.bootstrap,
    declarations: sharedConfig.declarations,
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule,
        ...sharedConfig.imports
    ],
    providers: [
        { provide: 'ORIGIN_URL', useValue: location.origin }, AuthGuard, JwtHelper, AuthHttp, AUTH_PROVIDERS
    ]
})
export class AppModule {
}
