namespace OWASP.Misconfiguration.Web.Before.Repository;

public class Refunds
{
    public Refunds()
    {
        RefundList = new List<Refund>
        {
            new Refund
            {
                RefundAmount = 35.00M,
                Email = "user@gmail.com"
            },
            new Refund
            {
                RefundAmount = 20.00M,
                Email = "user2@gmail.com"
            },
            new Refund
            {
                RefundAmount = 10,
                Email = "user3@gmail.com"
            },
        };
        CurrentBalance = 5000;
    }

    public List<Refund> RefundList { get; set; }

    public decimal CurrentBalance { get; set; }

    public class Refund
    {
        public decimal RefundAmount { get; set; }
        public string Email { get; set; }
    }
}