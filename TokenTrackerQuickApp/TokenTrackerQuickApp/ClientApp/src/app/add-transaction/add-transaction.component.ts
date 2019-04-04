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
      this.users = x.sort(function (a, b) {
        var x = a.fullName.toLowerCase();
        var y = b.fullName.toLowerCase();
        if (x < y) { return -1; }
        if (x > y) { return 1; }
        return 0;
      });
      let user: any = this.acctService.currentUser;
      this.currentUser = this.users.filter(u => u.id == user.id)[0];
    });

  }

  submit() {
    let t: Transaction = new Transaction();
    t.awardFromId = this.currentUser.userId;
    t.awardMessage = this.awardReason ? this.awardReason : "";
    t.awardToId = this.awardToUser;
    t.points = this.tokenAwardAmount;

    this.postTransaction(t).subscribe(x => {
      let user: User = this.users.filter(u => u.userId == t.awardToId)[0];
      console.log("result from transaction: ", x);
      alert("You've awarded " + t.points + " tokens to " + user.fullName);

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
