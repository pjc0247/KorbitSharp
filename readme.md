KorbitSharp
====

Ticker
----
__simple__
```cs
var type = CurrencyType.Ethereum;

var eth_krw = await Currency.QueryAsync(type);
```

__detailed__
```cs
var type = CurrencyType.Ethereum;

var response = await Currency.QueryDetailedAsync(type);

var eth_krw = response.last;
var ask = response.ask;
var bid = response.bid;
```