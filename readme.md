KorbitSharp
====

Auth
----
__Non-Public__ API를 사용하기 위해서는 먼저 __로그인__과정을 수행해야 합니다.
```cs
Auth.Login(clientId, clientSecret, username, password);
Auth.EnableExchange(nonce);
```
`EnableExchange` 메소드를 호출하기 이전에는 거래 API를 호출할 수 없습니다.

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

Exchange
----
__BUY__
```cs
var status = 
    await Exchange.PlaceBidAsync(CurrencyType.Bitcoin, PRICE, AMOUNT);
```

__SELL__
```cs
var status = 
    await Exchange.PlaceAskAsync(CurrencyType.Bitcoin, PRICE, AMOUNT);
```

__StatusCode__
```cs
if (status == ExchangeStatusCode.Success)
    ; // 성공
else if (status == ExchangeStatusCode.NotEnoughKrw)
    ; // KRW 잔액 부족
```

Wallet
----

```cs
var wallet = await Wallet.QueryWalletAsync(CurrencyType.Bitcoin);

wallet.balance.krwValue;
```
