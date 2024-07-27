using System;
public class InvalidTransactionException : Exception {
    public TransactionData TransactionData { get; }

    public InvalidTransactionException()
    {
        
    }
    public InvalidTransactionException(string message)
        : base (message)
    {
        
    }

    public InvalidTransactionException(string message, Exception inner)
        : base (message, inner)
    {
        
    }

    public InvalidTransactionException(string message, TransactionData transactionData)
    {
        
    }

    public InvalidTransactionException(string message, TransactionData transactionData, Exception inner)
    {
        
    }
}

    public class TransactionData {
        public string Sender { get; init; }
        public string Receiver { get; init; }
        public decimal Amount { get; init; }
    }

