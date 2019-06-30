using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockQuantity
{
    class stockUpdate
    {
        //public static void updatestock()
        //{
        //    var db = new AliFashionEntities();
        //    var list = db.ItemStockTracks.OrderBy(aa => aa.Date).ToList();
        //    var dictionary = new Dictionary<string, float>();

        //    foreach (var item in list)
        //    {
        //        item.ItemCode.Trim();

        //        string key = item.ItemCode.Trim() + "_" + item.ShopCode;

        //        if (dictionary.ContainsKey(key))
        //        {
        //            float value = dictionary[key];
        //            value -= (float)item.SaleQty;
        //            value -= (float)item.ShopOut;
        //            value += (float)item.ShopIn;
        //            value -= (float)item.SaleExchange;
        //            value += (float)item.ReturnToShop;
        //            value -= (float)item.ReturnFromShop;
        //            value += (float)item.ReceiveAtShop;
        //            value += (float)item.StockOpening;
        //            dictionary[key] = value;
        //        }

        //        else
        //        {
        //            float value = 0;
        //            value -= (float)item.SaleQty;
        //            value -= (float)item.ShopOut;
        //            value += (float)item.ShopIn;
        //            value -= (float)item.SaleExchange;
        //            value += (float)item.ReturnToShop;
        //            value -= (float)item.ReturnFromShop;
        //            value += (float)item.ReceiveAtShop;
        //            value += (float)item.StockOpening;
        //            dictionary.Add(key, value);
        //        }

        //        item.StockQty = dictionary[key];
        //    }

        //    //var wq = list.Where(qq => qq.ItemCode.Trim().Equals("2256")).ToList();
        //    //wq = wq.Where(qq => qq.ShopCode == 2).ToList();
        //    //wq = wq.OrderBy(qq => qq.Date).ToList();

        //    //foreach (var ww in wq)
        //    //{
        //    //    Console.Write(ww.Date);
        //    //    Console.Write("   ");
        //    //    Console.Write(ww.StockQty);
        //    //    Console.WriteLine();
        //    //}

        //    db.SaveChanges();


        //}



        //public static void CalculateShelfLife()
        //{

        //    var shelfLifeList = new List<ShelfLife>();
        //    var db = new AliFashionEntities();
        //    var itemsCodes = db.ItemStockTracks.Select(qq => qq.ItemCode).Distinct();

        //    foreach (var itemCode in itemsCodes)
        //    {
        //        DateTime startDate = new DateTime();
        //        DateTime endDate = new DateTime();
        //        for (int i = 2; i <= 4; i++)
        //        {
        //            var itemList = db.ItemStockTracks.Where(qq => qq.ItemCode.Equals(itemCode) && qq.ShopCode == i).OrderBy(qq => qq.Date).ToList();
        //            float minQuantity = 0;
        //            float totalSales = 0;
        //            float shelfLife = 0;
        //            bool isShefLifeCalc = false;
        //            var totalItems = itemList.Count();
        //            int loopCount = 0;
        //            int intervalq = 0;
        //            bool isInitialized = false;
        //            if (itemCode.Trim().Equals("1"))
        //            {
        //                int sadsads = 123;
        //            }
        //            foreach (var item in itemList)
        //            {
        //                loopCount++;

        //                ShelfLife life = new ShelfLife();
        //                totalSales += (int)item.SaleQty;
        //                //reseting the interval
        //                if (item.ReceiveAtShop > 0)
        //                {
        //                    if (loopCount != 1 && isInitialized)
        //                    {
        //                        //calc the shelf life
        //                        if (!isShefLifeCalc)
        //                        {


        //                            intervalq++;
        //                            var interval = item.Date - startDate;
        //                            var days = interval.Value.Days;
        //                            shelfLife = totalSales / days;

        //                            life.EndDate = item.Date;
        //                            life.StartDate = startDate;
        //                            life.itemCode = item.ItemCode;
        //                            life.interval = intervalq;
        //                            life.shlefLife = shelfLife;
        //                            life.shopCode = item.ShopCode;
        //                            shelfLifeList.Add(life);


        //                        }
        //                        //just save shelf life
        //                        else
        //                        {
        //                            if (life.shopCode != null)
        //                            {
        //                                intervalq++;
        //                                life.interval = intervalq;


        //                                shelfLifeList.Add(life);
        //                            }
        //                        }
        //                    }

        //                    isInitialized = true;
        //                    startDate = (DateTime)item.Date;
        //                    minQuantity = (float)(item.ReceiveAtShop * 10) / 100;
        //                    totalSales = 0;


        //                }
        //                //one sol could be the calculation in end of list or reset of interval but may be keep it simple


        //                else if (item.StockQty <= minQuantity)
        //                {
        //                    // end ofinterval
        //                    if (isInitialized)
        //                    {
        //                        var interval = item.Date - startDate;
        //                        var days = interval.Value.Days;
        //                        shelfLife = totalSales / days;

        //                        life.EndDate = item.Date;
        //                        life.StartDate = startDate;
        //                        life.itemCode = item.ItemCode;
        //                        life.shlefLife = shelfLife;
        //                        life.shopCode = item.ShopCode;

        //                        isShefLifeCalc = true;
        //                    }
        //                }

        //                //do something for the end of foreach loop
        //                if (loopCount == totalItems)
        //                {
        //                    if (!isShefLifeCalc && isInitialized)
        //                    {
        //                        var interval = item.Date - startDate;
        //                        var days = interval.Value.Days;
        //                        shelfLife = totalSales / days;

        //                        intervalq++;
        //                        life.EndDate = item.Date;
        //                        life.StartDate = startDate;
        //                        life.itemCode = item.ItemCode;
        //                        life.interval = intervalq;
        //                        life.shlefLife = shelfLife;
        //                        life.shopCode = item.ShopCode;


        //                        shelfLifeList.Add(life);
        //                    }

        //                    else
        //                    {
        //                        if (life.shopCode != null && isInitialized)
        //                        {
        //                            intervalq++;
        //                            life.interval = intervalq;

        //                            shelfLifeList.Add(life);
        //                        }
        //                    }
        //                }



        //            }

        //        }



        //    }



        //    var listttt = shelfLifeList.OrderBy(aa => aa.shlefLife);

        //    shelfLifeList = shelfLifeList.Where(qq => !(double.IsNaN((double)qq.shlefLife) || double.IsInfinity((double)qq.shlefLife))).ToList();


        //    db.ShelfLives.AddRange(shelfLifeList);
        //    db.SaveChanges();
        //}



        public static void CalculateShelfLifeNew()
        {
            var shelfLifeList = new List<ShelfLife>();
            var db = new AliFashionEntities1();            
            var itemsCodes = db.newItemStockTracks.Select(qq => qq.ItemCode).Distinct();

            foreach (var itemCode in itemsCodes)
            {
                DateTime startDate = new DateTime();
                DateTime endDate = new DateTime();
                for (int i = 2; i <= 4; i++)
                {
                    var itemList = db.newItemStockTracks.Where(qq => qq.ItemCode.Equals(itemCode) && qq.ShopCode == i).OrderBy(qq => qq.Date).ToList();
                    float minQuantity = 0;
                    float totalSales = 0;
                    float shelfLife = 0;
                    bool isShefLifeCalc = false;
                    var totalItems = itemList.Count();
                    int loopCount = 0;
                    int intervalq = 0;
                    bool isInitialized = false;
                    
                    foreach (var item in itemList)
                    {
                        loopCount++;

                        ShelfLife life = new ShelfLife();
                        totalSales += (int)item.SaleQty;
                        //reseting the interval
                        if (item.TotalReceived > 0)
                        {
                            if (loopCount != 1 && isInitialized)
                            {
                                //calc the shelf life
                                if (!isShefLifeCalc)
                                {


                                    intervalq++;
                                    var interval = item.Date - startDate;
                                    var days = interval.Value.Days;
                                    shelfLife = totalSales / days;

                                    life.EndDate = item.Date;
                                    life.StartDate = startDate;
                                    life.itemCode = item.ItemCode;
                                    life.interval = intervalq;
                                    life.shlefLife = shelfLife;
                                    life.shopCode = item.ShopCode;
                                    shelfLifeList.Add(life);


                                }
                                //just save shelf life
                                else
                                {
                                    if (life.shopCode != null)
                                    {
                                        intervalq++;
                                        life.interval = intervalq;


                                        shelfLifeList.Add(life);
                                    }
                                }
                            }

                            isInitialized = true;
                            startDate = (DateTime)item.Date;
                            minQuantity = (float)(item.TotalReceived * 10) / 100;
                            totalSales = 0;


                        }
                        //one sol could be the calculation in end of list or reset of interval but may be keep it simple


                        else if (item.StockQty <= minQuantity)
                        {
                            // end ofinterval
                            if (isInitialized)
                            {
                                var interval = item.Date - startDate;
                                var days = interval.Value.Days;
                                shelfLife = totalSales / days;

                                life.EndDate = item.Date;
                                life.StartDate = startDate;
                                life.itemCode = item.ItemCode;
                                life.shlefLife = shelfLife;
                                life.shopCode = item.ShopCode;

                                isShefLifeCalc = true;
                            }
                        }

                        //do something for the end of foreach loop
                        if (loopCount == totalItems)
                        {
                            if (!isShefLifeCalc && isInitialized)
                            {
                                var interval = item.Date - startDate;
                                var days = interval.Value.Days;
                                shelfLife = totalSales / days;

                                intervalq++;
                                life.EndDate = item.Date;
                                life.StartDate = startDate;
                                life.itemCode = item.ItemCode;
                                life.interval = intervalq;
                                life.shlefLife = shelfLife;
                                life.shopCode = item.ShopCode;


                                shelfLifeList.Add(life);
                            }

                            else
                            {
                                if (life.shopCode != null && isInitialized)
                                {
                                    intervalq++;
                                    life.interval = intervalq;

                                    shelfLifeList.Add(life);
                                }
                            }
                        }



                    }

                }



            }



            var listttt = shelfLifeList.OrderBy(aa => aa.shlefLife);

            shelfLifeList = shelfLifeList.Where(qq => !(double.IsNaN((double)qq.shlefLife) || double.IsInfinity((double)qq.shlefLife))).ToList();


            //var list = new List<int>();
            //int totalDays = 0;
            //foreach (var lifeee in shelfLifeList)
            //{
            //    totalDays += (lifeee.EndDate - lifeee.StartDate).Value.Days;
            //    list.Add((lifeee.EndDate - lifeee.StartDate).Value.Days);
            //    list.Sort();
            //}

            //var avg = totalDays / shelfLifeList.Count();

            //var extraIntervals = shelfLifeList.Where(aa => aa.interval > 1).Select(aa => aa.itemCode).ToList();
            //extraIntervals.Sort();
            //int shortint = 0;

            //var removeIntervalsList = new List<ShelfLife>();


            //foreach (var exInt in extraIntervals)
            //{
            //    var itemsIntervalList = shelfLifeList.Where(aa => aa.itemCode.Trim().Equals(exInt.Trim()));

            //    foreach (var itemm in itemsIntervalList)
            //    {
                    
            //        var days = (itemm.EndDate - itemm.StartDate).Value.Days;

                    

            //        if (days <= 13)
            //        {

            //            removeIntervalsList.Add(itemm);

            //        }

                   
            //    }
            //}


            //foreach (var removed in removeIntervalsList)
            //{

            //    var qwe = shelfLifeList.Where(aa => aa.EndDate == removed.EndDate && aa.interval == removed.interval && aa.itemCode == removed.itemCode && aa.shopCode == removed.shopCode && aa.StartDate == removed.StartDate).FirstOrDefault();
            //    shelfLifeList.Remove(qwe);
            //}

            db.ShelfLives.AddRange(shelfLifeList);
            db.SaveChanges();
        }



        public static void CleanShortIntervals()
        {

            var db = new AliFashionEntities1();
            var lisst = db.ShelfLives.ToList();

            var removedlist = new List<ShelfLife>();

            foreach (var item in lisst)
            {

                var days = (item.EndDate - item.StartDate).Value.Days;

                if (days <= 13)
                {
                    removedlist.Add(item);
                }

            }


            
int asdsad = 213;
            //foreach (var item in removedlist)
            //{
            //    lisst.Remove(item);
            //}

            db.ShelfLives.RemoveRange(removedlist);
            db.SaveChanges();

        }


        public static void SetInterval()
        {
            var db = new AliFashionEntities1();

            var lisst = db.ShelfLives.ToList();

            var itemsCodes = lisst.Select(aa => aa.itemCode).Distinct().ToList();


            var finalList = new List<ShelfLife>();


            for (int i = 2; i <= 4; i++)
            {
                foreach (var code in itemsCodes)
                {
                    var alist = lisst.Where(aa => aa.shopCode == i && aa.itemCode.Trim().Equals(code.Trim())).OrderBy(aa=>aa.StartDate).ToList();

                    int inter = 0;

                    foreach (var item in alist)
                    {
                        inter++;

                        item.interval = inter;
                        finalList.Add(item);
                    }


                }
            }

            List<shelfLifeBak> baklist = new List<shelfLifeBak>();

            foreach (var item in finalList)
            {
                var itemm = new shelfLifeBak();
                itemm.EndDate = item.EndDate;
                itemm.id = item.id;
                itemm.interval = item.interval;
                itemm.itemCode = item.itemCode;
                itemm.shlefLife = item.shlefLife;
                itemm.shopCode = item.shopCode;
                itemm.StartDate = item.StartDate;
                baklist.Add(itemm);
            }

            db.shelfLifeBaks.AddRange(baklist);
        //    db.SaveChanges();
        }


        public static void AvgInterval()
        {
            var db = new AliFashionEntities1();
            var lisst = db.ShelfLives.ToList();
            var itemsCodes = lisst.Select(aa => aa.itemCode).Distinct().ToList();
            var avgIntervalList = new List<AvgIntervalShelf>();

            for (int i = 2; i <= 4; i++)
            {
                foreach (var code in itemsCodes)
                {
                    var alist = lisst.Where(aa => aa.shopCode == i && aa.itemCode.Trim().Equals(code.Trim())).OrderBy(aa => aa.StartDate).ToList();

                    if (alist.Count < 1)
                    {
                        continue;
                    }

                    var sum = alist.Select(aa => aa.shlefLife).Sum();
                    var count = alist.Count();
                    var avg = sum / count;
                    var avgLife = new AvgIntervalShelf();
                    avgLife.shlefLife = avg;

                    var sample = alist.FirstOrDefault();
                    avgLife.itemCode = sample.itemCode;                    
                    avgLife.shopCode = sample.shopCode;

                    avgIntervalList.Add(avgLife);
                }
            }

            db.AvgIntervalShelves.AddRange(avgIntervalList);
            db.SaveChanges();
        }




        public static void AvgIntervalShop()
        {
            var db = new AliFashionEntities1();
            var lisst = db.ShelfLives.ToList();
            var itemsCodes = lisst.Select(aa => aa.itemCode).Distinct().ToList();
            

                foreach (var code in itemsCodes)
                {
                    var alist = lisst.Where(aa =>  aa.itemCode.Trim().Equals(code.Trim())).OrderBy(aa => aa.StartDate).ToList();

                    if (alist.Count < 1)
                    {
                        continue;
                    }

                    var sum = alist.Select(aa => aa.shlefLife).Sum();
                    var count = alist.Count();
                    var avg = sum / count;
                var itemmcode = long.Parse(code.Trim());
                   var avgLife = db.ItemsShelfLives.Where(aa => aa.ItemCode == itemmcode).FirstOrDefault();
                    avgLife.ShelfLife = avg;
                
                }
            

            
            db.SaveChanges();
        }

    }
}
