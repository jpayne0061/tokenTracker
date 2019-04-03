// =============================
// Email: info@ebenmonney.com
// www.ebenmonney.com/templates
// =============================

import { Component } from '@angular/core';
import { fadeInOut } from '../../services/animations';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Customer } from '../../models/customer';
import { map } from 'rxjs/operators';


@Component({
    selector: 'customers',
    templateUrl: './customers.component.html',
    styleUrls: ['./customers.component.scss'],
    animations: [fadeInOut]
})
export class CustomersComponent {

  public customers: Customer[];

  constructor(private httpClient: HttpClient) {
    this.getChallengesService().subscribe(x => {
      console.log("customers: ", x);
      this.customers = x;
    });
  }

  getChallengesService(): Observable<Customer[]> {
    return this.httpClient.get<Customer[]>('api/Customer')
      .pipe(map(res => res));
  }

}
