namespace AssassinCore.Where
{
    // 
    public partial interface IWhereClauseBuilder<T>
        where T : class
    {
        IWhereClauseBuilder<T> And(); // {AND}

        IWhereClauseBuilder<T> Or(); // {OR}

        IWhereClauseBuilder<T> StartEscape(); // {(}

        IWhereClauseBuilder<T> AndStartEscape(); // {AND} {(}

        IWhereClauseBuilder<T> OrStartEscape(); // {OR} {(}

        IWhereClauseBuilder<T> EndEscape(); // {)}

        IWhereClauseBuilder<T> Clear();

        WhereClauseResult Build();
    }
}