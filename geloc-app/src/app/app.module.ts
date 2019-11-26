//import { fakeBackendProvider } from './_helpers/fake-backend';
import { appRoutingModule } from './app.routing';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule} from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { JwtInterceptor, ErrorInterceptor } from './_helpers';


import { AppComponent } from './app.component';
import { PessoasListaComponent } from './pessoas-lista/pessoas-lista.component';


@NgModule({
    imports: [BrowserModule,
              ReactiveFormsModule,
              HttpClientModule,
              appRoutingModule],
    declarations: [AppComponent,
                   HomeComponent,
                   LoginComponent,
                   PessoasListaComponent],
    providers: [
        { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
        { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },

        // provider para criar um falso backe-end
        //fakeBackendProvider
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }
