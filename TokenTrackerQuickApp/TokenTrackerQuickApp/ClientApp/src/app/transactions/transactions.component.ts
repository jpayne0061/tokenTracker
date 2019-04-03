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
  public tableReady: boolean = false;

  constructor(private httpClient: HttpClient) { }

  ngOnInit() {
    this.getTransactions().subscribe(x => {
      this.transactions = x;
      console.log("all transactions from TRX: ", x);
      this.checkin();
    });

    this.getAllUsers().subscribe(x => {
      console.log("all users from TRX: ", x);
      this.users = x;
      this.checkin();
    });
  }

  checkin() {
    if (this.transactions && this.users) {
      for (var i = 0; i < this.transactions.length; i++) {
        let fromUserName: string = this.users.filter(u => u.userId == this.transactions[i].awardFromId)[0].fullName;
        let toUserName: string = this.users.filter(u => u.userId == this.transactions[i].awardToId)[0].fullName;

        console.log("fromUserName: ", fromUserName);
        console.log("toUserName: ", toUserName);

        this.transactions[i].awardFromName = fromUserName;
        this.transactions[i].awardToName = toUserName;
        this.tableReady = true;
      }
    }
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
