<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Calculate Interest</title>
</head>
<body>
<form method="post">
    <label for="amount">Enter amount</label>
    <input id="amount" name="amount"><br>
    <input type="radio" id="usd" name="currency" value="USD">
    <label for="usd">USD</label>
    <input type="radio" id="eur" name="currency" value="ËUR">
    <label for="eur">EUR</label>
    <input type="radio" id="bgn" name="currency" value="BGN">
    <label for="bgn">BGN</label><br>
    <label for="interest">Compound Interest Amount</label>
    <input id="interest" name="interest"><br>
    <select id="period" name="period">
        <option value="6">6 Months</option>
        <option value="12">1 year</option>
        <option value="24">2 year</option>
        <option value="60">5 year</option>
    </select>
    <input type="submit" value="Calculate" name="submit">

  <?php
  if ($_POST && isset($_POST["submit"])) {
      if(isset($_POST["amount"]) && isset($_POST["currency"]) && isset($_POST["interest"]) && isset($_POST["period"])) {
          $amount = $_POST["amount"];
          $currency = $_POST["currency"];
          $interest = $_POST["interest"];
          $period = $_POST["period"];

          if(is_numeric($amount) && is_numeric($interest) && is_numeric($period)) {
              if($interest > 0 && $interest <= 100) {
                  $years = $period / 12;
                  $value = $amount * pow(1 + ($interest / 100) / 12, 12 * $years);
                  echo formatCurrency($value, $currency);

              }
              else {
                  echo "The number must be between 0 and 100.";
              }
          }
          else {
              echo "Wrong input!";
          }
      }
      else {
          echo "You must fill all the fields.";
      }
  }

  function formatCurrency($amount, $currency) {
      $roundedAmount = round($amount, 2);
      switch($currency) {
          case "USD": return "$" . $roundedAmount;
          case "EUR": return "€" . $roundedAmount;
          case "BGN": return " лв." . $roundedAmount;
          default: return $roundedAmount;
      }

  }
  ?>

</form>
</body>
</html>