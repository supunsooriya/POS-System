import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-addproduct',
  templateUrl: './addproduct.component.html',
  styleUrls: ['./addproduct.component.css']
})
export class AddproductComponent implements OnInit {

  constructor(
    private _router: Router
  ) {

  }

  ngOnInit() {
  }

  backToList() {
    this._router.navigate(['fetch-data']);
  }

}
