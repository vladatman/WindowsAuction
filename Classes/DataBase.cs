using AuctionProgram.Classes.Lots;
using AuctionProgram.Classes.Products;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AuctionProgram.Classes
{
    public class DataBase
    {
        private string connectionString = @"Data Source=NITRO_VLAD;Initial Catalog=Auction;Integrated Security=True;Encrypt=False";
        private SqlConnection conn;

        public DataBase()
        {
            conn = new SqlConnection(connectionString);
        }

        public List<Bidder> getBidders()
        {
            List<Bidder> bidders = new List<Bidder>();
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Bidder;", conn);
            command.ExecuteNonQuery();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    bidders.Add(new Bidder(Convert.ToInt32(reader["id"].ToString()), reader["name"].ToString(), reader["email"].ToString()));
                }
                conn.Close();
            }

            return bidders;
        }

        public List<Product> getLots(MainForm mainForm)
        {
            List<Product> lots = new List<Product>();
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT Lot.*, Bid.money FROM Lot LEFT JOIN (SELECT lot_id, MAX(money) AS money FROM Bid GROUP BY lot_id) AS Bid ON Lot.id = Bid.lot_id;", conn);
            command.ExecuteNonQuery();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                bool IsExist = false;

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"].ToString());
                    DateTime expirationTime = reader.GetDateTime(reader.GetOrdinal("expirationTime"));

                    if (mainForm.auction != null)
                    {
                        foreach (Product lot in mainForm.auction.lots)
                        {
                            if (lot.Id == id)
                            {
                                IsExist = true;
                                break;
                            }
                        }
                    }

                    if (IsExist)
                    {
                        IsExist = false;
                        continue;
                    }

                    if (expirationTime < DateTime.Now)
                    {
                        continue;
                    }

                    int money = Convert.ToInt32(reader["money"].ToString());

                    switch (reader["type"].ToString().ToLower())
                    {
                        case "car":

                            string carBrand = reader["brand"].ToString();
                            string carModel = reader["model"].ToString();
                            string carColor = reader["color"].ToString();
                            float total_km = float.Parse(reader["total_km"].ToString());

                            lots.Add(new CarLot(id, carBrand, carModel, carColor, total_km, money, expirationTime, mainForm).createLot());

                            break;
                        case "telephone":
                            string telephoneBrand = reader["brand"].ToString();
                            string telephoneModel = reader["model"].ToString();
                            string telephoneColor = reader["color"].ToString();
                            int batteryPower = Convert.ToInt32(reader["battery_power"].ToString());

                            lots.Add(new TelephoneLot(id, telephoneBrand, telephoneModel, telephoneColor, batteryPower, money, expirationTime, mainForm).createLot());

                            break;
                        case "house":
                            string location = reader["location"].ToString();
                            string style = reader["style"].ToString();
                            DateTime builtTime = reader.GetDateTime(reader.GetOrdinal("builtTime"));

                            lots.Add(new HouseLot(id, location, style, builtTime, money, expirationTime, mainForm).createLot());

                            break;
                        default:
                            break;
                    }
                }
                conn.Close();
            }

            return lots;
        }

        public int getLastBid(Product product)
        {
            int money = 0;
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT MAX(money) as money FROM Bid WHERE lot_id = @id;", conn);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    money = Convert.ToInt32(reader["money"].ToString());
                }
                conn.Close();
            }

            return money;
        }

        public void makeBid(Bidder bidder, Product lot, int bidAmount)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Bid (bidder_id, lot_id, money) VALUES(@bidder_id, @lot_id, @money);", conn);
            command.Parameters.AddWithValue("@bidder_id", bidder.Id);
            command.Parameters.AddWithValue("@lot_id", lot.Id);
            command.Parameters.AddWithValue("@money", bidAmount);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void addCar(string brand, string model, string color, float totalKm, DateTime expDate)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Lot (type, brand, model, color, total_km, expirationTime) VALUES(@type, @brand, @model, @color, @totalKm, @expDate);", conn);
            command.Parameters.AddWithValue("@type", "Car");
            command.Parameters.AddWithValue("@brand", brand);
            command.Parameters.AddWithValue("@model", model);
            command.Parameters.AddWithValue("@color", color);
            command.Parameters.AddWithValue("@totalKm", totalKm);
            command.Parameters.AddWithValue("@expDate", expDate.ToString());
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void addTelephone(string brand, string model, string color, int batteryPower, DateTime expDate)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Lot (type, brand, model, color, battery_power, expirationTime) VALUES(@type, @brand, @model, @color, @batteryPower, @expDate);", conn);
            command.Parameters.AddWithValue("@type", "Telephone");
            command.Parameters.AddWithValue("@brand", brand);
            command.Parameters.AddWithValue("@model", model);
            command.Parameters.AddWithValue("@color", color);
            command.Parameters.AddWithValue("@batteryPower", batteryPower);
            command.Parameters.AddWithValue("@expDate", expDate.ToString());
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void addHouse(string location, string style, DateTime builtDate, DateTime expDate)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Lot (type, location, style, builtTime, expirationTime) VALUES(@type, @location, @style, @builtDate, @expDate);", conn);
            command.Parameters.AddWithValue("@type", "House");
            command.Parameters.AddWithValue("@location", location);
            command.Parameters.AddWithValue("@style", style);
            command.Parameters.AddWithValue("@builtDate", builtDate.Date.ToString());
            command.Parameters.AddWithValue("@expDate", expDate.ToString());
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
