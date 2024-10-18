using FluentResults;

namespace IATec.Shared.Application.Wrappers;

public static class PagePaginateLite
{
    public static Task<Result<Page<T>>> Paginate<T>(
        this IQueryable<T> query,
        int page,
        int limit)
    {
        var length = query.Count();

        if (length == 0)
        {
            return Task.FromResult(Result.Ok(Page<T>.Set(page, [])));
        }

        var list = query
            .Skip(page * limit)
            .Take(limit)
            .ToList();

        var task = new Task<Result<Page<T>>>(() => Result.Ok(
            Page<T>.Set(length, list)));

        task.RunSynchronously();

        return task;
    }
}