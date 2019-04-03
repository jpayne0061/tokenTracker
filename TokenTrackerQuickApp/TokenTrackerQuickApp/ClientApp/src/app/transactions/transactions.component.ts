import { Component, OnInit } from '@angular/core';
import { fadeInOut } from '../services/animations';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Customer } from '../models/customer';
import { map } from 'rxjs/operators';
import { Transaction } from '../models/transaction';
import { User } from '../models/user';


@Component({
  selector: 'app-transactions',
  templateUrl: './transactions.component.html',
  styleUrls: ['./transactions.component.scss']
})
export class TransactionsComponent implements OnInit {

  public transactions: Transaction[];
  public users: User[];

  constructor(private httpClient: HttpClient) { }

  ngOnInit() {
    this.getTransactions().subscribe(x => {
      this.transactions = x;

      console.log("transactions: ", x);

      this.getAllUsers().subscribe(x => {
        console.log("all users from TRX: ", x);
        this.users = x;

        for (var i = 0; i < this.transactions.length; i++) {
          let fromUserName: string = this.users.filter(u => u.userId == this.transactions[i].AwardFromId)[0].fullName;
          let toUserName: string = this.users.filter(u => u.userId == this.transactions[i].AwardToId)[0].fullName;

          this.transactions[i].AwardFromName = fromUserName;
          this.transactions[i].AwardToName = toUserName;
        }
      });

    });
  }

  getTransactions(): Observable<Transaction[]> {
    return this.httpClient.get<Transaction[]>('api/PointTransaction')
      .pipe(map(res => res));
  }

  getAllUsers(): Observable<User[]> {
    return this.httpClient.get<User[]>('api/Account/users')
      .pipe(map(res => res));
  }

}
