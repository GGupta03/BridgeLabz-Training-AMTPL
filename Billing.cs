using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace BridgeLabzApp
{
    public class Billing
    {
        public static void Main()
        {
            string connstr = "Data Source=GAURAVPC\\SQLEXPRESS;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0";

            SqlConnection conn = new SqlConnection(connstr);
            SqlTransaction transaction = null;
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                SqlCommand insertBillCmd = new SqlCommand("INSERT INTO Bills (BillDate, TotalAmount) OUTPUT INSERTED.BillId VALUES (@Date, @Total)", conn, transaction);

                insertBillCmd.Parameters.AddWithValue("@Date", DateTime.Now);
                insertBillCmd.Parameters.AddWithValue("@Total", 1000);

                int billId = (int)insertBillCmd.ExecuteScalar();
                Console.WriteLine("Bill Inserted. BillId = " + billId);

                int productId = 1;
                int quantity = 2;
                decimal price = 500;

                SqlCommand stockCheckCmd = new SqlCommand("SELECT Stock FROM Inventory WHERE ProductId = @ProductId", conn, transaction);

                stockCheckCmd.Parameters.AddWithValue("@ProductId", productId);
                int stock = Convert.ToInt32(stockCheckCmd.ExecuteScalar());

                if (stock < quantity)
                {
                    throw new Exception("Insufficient stock available");
                }

                SqlCommand insertItemCmd = new SqlCommand("INSERT INTO BillItems (BillId, ProductId, Quantity, Price) VALUES (@BillId, @ProductId, @Qty, @Price)", conn, transaction);

                insertItemCmd.Parameters.AddWithValue("@BillId", 100);
                insertItemCmd.Parameters.AddWithValue("@ProductId", 101);
                insertItemCmd.Parameters.AddWithValue("@Qty", 2);
                insertItemCmd.Parameters.AddWithValue("@Price", 500);

                SqlCommand updateStockCmd = new SqlCommand("UPDATE Inventory SET Stock = Stock - @Qty WHERE ProductId = @ProductId", conn, transaction);

                updateStockCmd.Parameters.AddWithValue("@Qty", quantity);
                updateStockCmd.Parameters.AddWithValue("@ProductId", productId);

                updateStockCmd.ExecuteNonQuery();
                Console.WriteLine("Inventory Updated");


                transaction.Commit();
                Console.WriteLine("Transaction Completed Successfully");

            }

            catch
            {
                transaction?.Rollback();
                Console.WriteLine("Transaction Failed");
                Console.WriteLine("Reason: ", Exception.);
            }

            finally
            {
                conn.Close();
            }
        }
    }
}
