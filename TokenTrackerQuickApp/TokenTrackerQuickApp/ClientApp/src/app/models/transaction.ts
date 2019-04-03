import { Product } from "./product";

export class Transaction {
  public pointTransactionId: number;
  public transactionDate: Date;
  public productId: number;
  public points: number;
  public awardToId: number;
  public awardFromId: number;
  public awardMessage: string;
  public awardToName: string = "";
  public awardFromName: string = "";
}
