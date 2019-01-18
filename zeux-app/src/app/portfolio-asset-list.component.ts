import { Component, OnInit } from '@angular/core';
import { PortfolioService, IPortfolioAsset } from './shared/index';

@Component({
    template: `
        <portfolio-asset *ngFor="let asset of assets" [asset]="asset"></portfolio-asset>
    `
})
export class PortfolioAssetListComponent implements OnInit {
    assets: IPortfolioAsset[];

    constructor(private portfolioService: PortfolioService) {}

    ngOnInit() {
        this.portfolioService.getAssets().subscribe(assets => {
            this.assets = assets;
        });
    }
}