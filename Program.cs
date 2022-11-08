using DesignPattern;

#region Design Patterns

// Observers / (Concrete) Subscribers
var cuisine = new Cuisine();
var caisse = new Caisse();

// Subject / Publisher
var foodDispatch = new FoodDispatch();
foodDispatch.Attach(cuisine); //Subscribe
foodDispatch.Attach(caisse);

foodDispatch.OrderSomeFood("{ name : pizza fromage }"); //Notify subscribers

#endregion