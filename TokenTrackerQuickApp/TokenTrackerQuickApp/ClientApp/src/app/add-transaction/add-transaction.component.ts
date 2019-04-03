import { Component, OnInit } from '@angular/core';
import { fadeInOut } from '../services/animations';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Customer } from '../models/customer';
import { map } from 'rxjs/operators';
import { Transaction } from '../models/transaction';
import { User } from '../models/user';
import { AccountService } from '../services/account.service';

@Component({
  selector: 'app-add-transaction',
  templateUrl: './add-transaction.component.html',
  styleUrls: ['./add-transaction.component.scss']
})
export class AddTransactionComponent implements OnInit {


  public currentUser: User;
  public totalTokensAwarded: string;
  public awardsBankBalance: number;
  public giveBankBalance: number;

  public tokenAwardAmount: number;
  public awardReason: string;

  public users: User[];
  public awardToUser: number;
  public transaction = new Transaction();


  constructor(private httpClient: HttpClient, private acctService: AccountService) { }

  ngOnInit() {
    //let user: User = new User();
    //user.FullName = "Maegan Powell";
    //user.UserId = 1;

    //let user2: User = new User();
    //user2.FullName = "John Sammon";
    //user2.UserId = 2;

    //let user3: User = new User();
    //user3.FullName = "Bryan Massey";
    //user3.UserId = 3;

    //this.users = [user, user2, user3];

    //this.getUser().subscribe(x => {
    //  console.log("current user: ", x);
    //  this.currentUser = x;
    //});

    this.getAllUsers().subscribe(x => {
      console.log("all users: ", x);
      this.users = x;
      let user: any = this.acctService.currentUser;
      this.currentUser = this.users.filter(u => u.id == user.id)[0];
    });

  }

  submit() {
    let t: Transaction = new Transaction();
    t.AwardFromId = this.currentUser.userId;
    t.AwardMessage = this.awardReason ? this.awardReason : "";
    t.AwardToId = this.awardToUser;
    t.Points = this.tokenAwardAmount;

    this.postTransaction(t).subscribe(x => {
      console.log("result from transaction: ", x);
    });
  }


  getUser(): Observable<User> {
    return this.httpClient.get<User>('api/Account/users/me')
      .pipe(map(res => res));
  }

  getAllUsers(): Observable<User[]> {
    return this.httpClient.get<User[]>('api/Account/users')
      .pipe(map(res => res));
  }

  postTransaction(submission: any) {
    return this.httpClient.post('api/PointTransaction/', submission)
      .pipe(map(res => res));
  }

}
