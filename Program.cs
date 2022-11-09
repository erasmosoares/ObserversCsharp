#region Premier exemple utilisant l'implementation du design patterns

// 1 - Objet ou message qui sera envoyé.
using CoreEvents;

var food_designPattern = new DesignPattern.Models.Food { Name = "Pizza" };

// 2 - Déclaration des observateurs/subscribers (Qui reçoit le message)
var cuisine_designPattern = new DesignPattern.Cuisine();
var caisse_designPattern = new DesignPattern.Caisse();

// 3 - Déclaration du subject/publisher (Qui envoie le message)
var foodDispatch_designPattern = new DesignPattern.FoodDispatch();

// 4 - Enregistrement des observateurs 
foodDispatch_designPattern.Attach(cuisine_designPattern);
foodDispatch_designPattern.Attach(caisse_designPattern);

// 5 - Publier le message
foodDispatch_designPattern.OrderSomeFood(food_designPattern);

#endregion


#region Deuxième exemple utilisant l'implémentation des observateurs à travers l'objet "Event" de C#

// 1 - Objet ou message qui sera envoyé.
var food_charpEvents = new CSharpEvents.Models.Food { Name = "Lasagna" };

// 2 - Déclaration des observateurs/subscribers (Qui reçoit le message)
var cuisine_charpEvents = new CSharpEvents.Cuisine();
var caisse_charpEvents = new CSharpEvents.Caisse();

// 3 - Déclaration du subject/publisher (Qui envoie le message)
var foodDispatch_charpEvents = new CSharpEvents.FoodDispatch();

// 4 - Enregistrement des observateurs 
foodDispatch_charpEvents.FoodOrdered += cuisine_charpEvents.OnFoodOrdered;
foodDispatch_charpEvents.FoodOrdered += caisse_charpEvents.OnFoodOrdered;

// 5 - Publier le message
foodDispatch_charpEvents.OrderSomeFood(food_charpEvents);

#endregion


#region Troisième exemple utilisant l'implémentation d'un agrégateur d'événements

// Configuration Startup.cs
var events = new CoreEvent();

// 1 - Objet ou message qui sera envoyé.
var food_aggregator = new Aggregator.Models.Food { Name = "Wine" };

// 2 - Déclaration des observateurs/subscribers (Qui reçoit le message)
var cuisine_aggregator = new Aggregator.Cuisine(events);
var caisse_aggregator = new Aggregator.Caisse(events);

// 3 - Déclaration du subject/publisher (Qui envoie le message)
var foodDispatch_aggregator = new Aggregator.FoodDispatch(events);

// 4 - Publier le message
foodDispatch_aggregator.OrderSomeFood(food_aggregator);

#endregion