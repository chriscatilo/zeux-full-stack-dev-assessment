import { Routes } from '@angular/router';
import { PortfolioAssetListComponent } from './portfolio-asset-list.component';
import { UnderConstructionComponent } from './under-construction.component'

export const appRoutes:Routes = [
    { path: 'my-assets', component: PortfolioAssetListComponent },
    { path: 'my-assets/all', redirectTo: 'my-assets', pathMatch: 'full' },
    { path: 'my-assets/:type', component: UnderConstructionComponent },
    { path: '', redirectTo: 'my-assets', pathMatch: 'full'}
];