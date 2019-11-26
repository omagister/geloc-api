import { PessoasListaComponent } from './pessoas-lista/pessoas-lista.component';
import { AuthGuard } from './_helpers/auth.guard';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home';
import { LoginComponent } from './login';

const routes: Routes = [
    { path: '', component: HomeComponent, canActivate: [AuthGuard] },
    { path: 'login', component: LoginComponent },
    { path: 'pessoas-lista', component: PessoasListaComponent, canActivate: [AuthGuard] },
    { path: '**', redirectTo: '' }
];

export const appRoutingModule = RouterModule.forRoot(routes);
