import { Product } from "./product";

export class Transaction {
  public PointTransactionId: number;
  public TransactionDate: Date;
  public ProductId: number;
  public Points: number;
  public AwardToId: number;
  public AwardFromId: number;
  public AwardMessage: string;
  public AwardToName: string;
  public AwardFromName: string;
  public Product: Product;
}
