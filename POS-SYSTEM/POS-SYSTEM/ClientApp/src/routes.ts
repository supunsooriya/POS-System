import { Routes } from '@angular/router';
import { HomeComponent } from './app/home/home.component';
import { CounterComponent } from './app/counter/counter.component';
import { FetchDataComponent } from './app/fetch-data/fetch-data.component';
import { AddproductComponent } from './app/addproduct/addproduct.component';

export const appRoutes: Routes = [

    { path: "", component: HomeComponent, pathMatch: "full" },
    { path: "counter", component: CounterComponent },
    { path: "fetch-data", component: FetchDataComponent },
    { path: "addnewproduct", component: AddproductComponent },
];
