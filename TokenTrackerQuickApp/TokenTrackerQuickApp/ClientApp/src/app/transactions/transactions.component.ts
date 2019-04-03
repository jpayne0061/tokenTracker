import { Component, OnInit } from '@angular/core';
import { fadeInOut } from '../services/animations';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Customer } from '../models/customer';
import { map } from 'rxjs/operators';
import { Transaction } from '../models/transaction';


@Component({
  selector: 'app-transactions',
  templateUrl: './transactions.component.html',
  styleUrls: ['./transactions.component.scss']
})
export class TransactionsComponent implements OnInit {

  constructor(private httpClient: HttpClient) { }

  ngOnInit() {
    this.getTransactions().subscribe(x => {
      console.log("transactions: ", x);
    });
  }

  getTransactions(): Observable<Transaction[]> {
    return this.httpClient.get<Transaction[]>('api/PointTransaction')
      .pipe(map(res => res));
  }

}
