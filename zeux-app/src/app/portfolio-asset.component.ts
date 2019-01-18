import { Component, Input } from '@angular/core';
import { IPortfolioAsset } from './shared/index';

@Component({
    selector: 'portfolio-asset',
    template: `
        <ul class="row portfolio">
            <li>
                <div class="product-type col-xs-12">{{asset?.productType}}</div>
                <div class="product-name col-xs-10">{{asset?.productName}}</div>
                <div class="asset-value col-xs-2">{{asset?.value}}</div>
                <div class="product-return col-xs-12">{{asset?.productReturn}}</div>
            </li>
        </ul>
    `
})
export class PortfolioAssetComponent {
    @Input() asset:IPortfolioAsset
}