using Q5;

CashRegister cr1 = new CashRegister();
CashRegister cr2 = new CashRegister();

cr1.AddItem();
cr1.AddItem();
cr1.AddItem();

cr2.AddItem();
cr2.AddItem();
cr2.AddItem();
cr2.AddItem();

cr1.DisplayInfo();
cr2.DisplayInfo();

cr1.TotalInfo();