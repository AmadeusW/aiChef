// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.
//#r "Fsharp.Data.dll"
#r "../packages/Newtonsoft.Json.7.0.1/lib/net45/Newtonsoft.Json.dll"
#r "..\packages\FSharp.Data.2.2.5\lib\portable-net40+sl5+wp8+win8\FSharp.Data.dll"

#load "Library1.fs"
open aiChef.Core

//#r @"C:\Users\Amadeus\Documents\GitHub\aiChef\src\aiChef\packages\Newtonsoft.Json.7.0.1\lib\net45\Newtonsoft.Json.dll"
open Newtonsoft.Json
open FSharp.Data
open System.IO

// Using Newtonsoft.Json
type Recipe = {
    name : string
    ingredients : string
    url : string
    image : string
    cookTime : string
    recipeYield: string
    datePublished : string
    prepTime : string
    description : string
}
let rawRecipes = File.ReadAllLines(@"C:\Users\Amadeus\Documents\GitHub\aiChef\data\openrecipes.json")
let recipes = rawRecipes |> Seq.map(fun (x) -> JsonConvert.DeserializeObject<Recipe>(x))
let allIngredients = recipes |> Seq.map(fun (x) -> x.ingredients.Split('\n'))
let ingredientTokens = allIngredients |> Seq.map(fun (x) -> x |> Seq.map(fun (y) -> y.Split(' ')))
let ingredientData = processAllIngredientTokens ingredientTokens

def processAllIngredientTokens

// TODO now: split ingredients into "amount", (optionally "extra") and "noun" tokens.
(*
// Using FSharp.Data
type Recipe = JsonProvider<""" [{"name": "string"}, {"ingredients": "string"}, {"url": "http://string/"}, {"image": "http://string/"}, {"cookTime": "PT"}, {"recipeYield": "8"}, {"datePublished": "2013-04-01"}, {"prepTime": "PT15M"}, {"description": "string"}] """>
let recipes = Recipe.Parse(jsonData)
let allIngredients = query { for recipe in recipes do select recipe.Ingredients } |> Seq.map(fun (x) -> x.Value.Split('\n'))
*)
