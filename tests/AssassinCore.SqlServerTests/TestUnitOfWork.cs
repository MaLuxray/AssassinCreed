
using System;
using System.Linq.Expressions;
using System.Threading;

using AssassinCore.SqlServer;
using AssassinCore.Storage;
using AssassinCore.Storage.Implements;
using AssassinCore.Where;
using Xunit;

namespace AssassinCore.SqlServerTests
{
    public class TestUnitOfWork
    {
        private static readonly IStorageConnectionString DefaultConnectionString
            = new LocalSqlserverDbConncetionString();
        private static readonly IDbConnectionFactory DefaultDbConnectionFactory
            = new SqlServerConnectionFactory(DefaultConnectionString);

        private readonly IUnitOfWork _unitOfWork;
        private readonly IItemStore _itemStore;
        private readonly IWhereClauseBuilder<Item> _whereClauseBuilder;

        public TestUnitOfWork()
        {
            _unitOfWork = new UnitOfWork(DefaultDbConnectionFactory);
        }

        [Fact]
        public void TestSelect()
        {
            _unitOfWork.ExecuteAsync(
                async (IStorageDbConnection conn, CancellationToken cancellation)
                    => await _itemStore.SelectAsync(conn, cancellation));
        }

        [Fact]
        public void TestTake()
        {
            _unitOfWork.ExecuteAsync(
                async (IStorageDbConnection conn, CancellationToken cancellation)
                    => await _itemStore.TakeAsync(conn, 10, cancellation));
        }

        [Fact]
        public void TestPage()
        {
            _unitOfWork.ExecuteAsync(
                async (IStorageDbConnection conn, CancellationToken cancellation)
                    => await _itemStore.PageAsync(conn, 10, 20, cancellation));
        }

        [Fact]
        public void TestFirstOrDefault()
        {
            _unitOfWork.ExecuteAsync(
                async (IStorageDbConnection conn, CancellationToken cancellation)
                    => await _itemStore.FirstOrDefaultAsync(conn, cancellation));
        }

        [Fact]
        public void TestSingleOrDefault()
        {
            _unitOfWork.ExecuteAsync(
                async (IStorageDbConnection conn, CancellationToken cancellation)
                    => await _itemStore.SingleOrDefaultAsync(conn, 11, cancellation));
        }

        [Fact]
        public void TestCount()
        {
            _unitOfWork.ExecuteAsync(
                async (IStorageDbConnection conn, CancellationToken cancellation)
                    => await _itemStore.CountAsync(conn, cancellation));
        }

        [Fact]
        public void TestExists()
        {
            _unitOfWork.ExecuteAsync(
                async (IStorageDbConnection conn, CancellationToken cancellation)
                    => await _itemStore.ExistsAsync(conn, cancellation));
        }

        [Fact]
        public void TestInsert()
        {
            _unitOfWork.ExecuteAsync(
                async (IStorageDbConnection conn, CancellationToken cancellation) =>
                {
                    var ignoredFields = new Expression<Func<Item, object>>[] { _ => _.Id, _ => _.LogicId, };
                    void Atf(int id, Item entity) => entity.Id = id;
                    await _itemStore.InsertAsync(conn, new Item(), ignoredFields, Atf, cancellation);
                });
        }

        [Fact]
        public void TestDelete()
        {
            _unitOfWork.ExecuteAsync(
                async (IStorageDbConnection conn, CancellationToken cancellation) =>
                {
                    var whereClause = _whereClauseBuilder.Equal(_ => _.Name, "deleted").Build();
                    await _itemStore.DeleteAsync(conn, 11, cancellation);
                    await _itemStore.DeleteAsync(conn, whereClause, cancellation);
                });
        }

        [Fact]
        public void TestUpdate()
        {
            _unitOfWork.ExecuteAsync(
                async (IStorageDbConnection conn, CancellationToken cancellation) =>
                {
                    var updateFields = new Expression<Func<Item, object>>[] { _ => _.Name, };
                    var whereClause = _whereClauseBuilder.Equal(_ => _.Id, 11).Build();
                    await _itemStore.UpdateAsync(conn, new Item() { Name = "updateName", }, updateFields, 11, cancellation);
                    await _itemStore.UpdateAsync(conn, new Item() { Name = "updateName", }, updateFields, whereClause, null, cancellation);
                });
        }
    }

    public class LocalSqlserverDbConncetionString : IStorageConnectionString
    {
        public string Value => "local";
    }
}