import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { PortfolioAssetListComponent } from './portfolio-asset-list.component';
import { PortfolioAssetComponent} from './portfolio-asset.component';
import { UnderConstructionComponent } from './under-construction.component';

import { PortfolioService } from './shared/portfolio.service';

import { RouterModule } from '@angular/router';
import { appRoutes } from './routes';

@NgModule({
  declarations: [
    AppComponent,
    PortfolioAssetListComponent,
    PortfolioAssetComponent,
    UnderConstructionComponent,
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(appRoutes),
    HttpClientModule
  ],
  providers: [
    PortfolioService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
