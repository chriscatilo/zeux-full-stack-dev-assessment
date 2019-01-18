import { Injectable } from '@angular/core';
import { Subject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { IPortfolioAsset } from './portfolio-asset.model'
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class PortfolioService {

    constructor(private http: HttpClient) {}

    getAssets():Observable<IPortfolioAsset[]> {
        
        const httpHeader = new HttpHeaders({
            'Authorization': 'bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJBY2NvdW50TmFtZSI6IkpvaG4gRG9lIiwiQWNjb3VudE51bWJlciI6IjEyMzQ1Njc4OTAifQ.zLyKWzsoFJPlCyoLxItx5J-oeXIvn_DkHdUlId0s6A8'
        });

        let observable = this.http
            .get<any[]>('https://localhost:5001/portfolio', { headers: httpHeader })
            .pipe(map(ToPortfolioAssets));

        return observable;
    } 
}

function ToPortfolioAssets(assets:any[]) {
    let result = assets.reduce<IPortfolioAsset[]>((agg, src) => {
        let value = (parseFloat(src.valuation) / 100).toFixed(2);
        let asset:IPortfolioAsset = {
            productName: src.productName,
            productType: src.productType,
            productReturn: `${src.returns}% ${src.returnsBasis}`,
            value: `£${value}`
        };
        agg.push(asset);
        return agg;
    }, []);
    return result;
}

const MOCK:IPortfolioAsset[] = [
    {
        productType: "Savings",
        productName: "Name of investment",
        productReturn: "2.34% Yearly",
        value: "£403.20"
    },
    {
        productType: "Savings",
        productName: "Name of investment",
        productReturn: "2.34% Yearly",
        value: "£403.20"
    },
    {
        productType: "Savings",
        productName: "Name of investment",
        productReturn: "2.34% Yearly",
        value: "£403.20"
    },
    {
        productType: "Savings",
        productName: "Name of investment",
        productReturn: "2.34% Yearly",
        value: "£403.20"
    },
    {
        productType: "Savings",
        productName: "Name of investment",
        productReturn: "2.34% Yearly",
        value: "£403.20"
    },
    {
        productType: "Savings",
        productName: "Name of investment",
        productReturn: "2.34% Yearly",
        value: "£403.20"
    },
    {
        productType: "Savings",
        productName: "Name of investment",
        productReturn: "2.34% Yearly",
        value: "£403.20"
    },
    {
        productType: "Savings",
        productName: "Name of investment",
        productReturn: "2.34% Yearly",
        value: "£403.20"
    },
    {
        productType: "Savings",
        productName: "Name of investment",
        productReturn: "2.34% Yearly",
        value: "£403.20"
    },
    {
        productType: "Savings",
        productName: "Name of investment",
        productReturn: "2.34% Yearly",
        value: "£403.20"
    },
];
