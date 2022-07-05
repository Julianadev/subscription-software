
Random random = new Random();

int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Sua assinatura expirou");
}

else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Sua assinatura expira amanhã");
    discountPercentage = 20;
}

else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Sua assinatura vence em {daysUntilExpiration} dias.");
    discountPercentage = 10;
}

else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Sua assinatura vai expirar em breve! Renove-a");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renove-a agora e salve {discountPercentage}%");
}