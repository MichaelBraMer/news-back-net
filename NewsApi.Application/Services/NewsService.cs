using NewsApi.Domain.Entities;
using NewsApi.Domain.Interfaces;

namespace NewsApi.Application.Services
{
    public class NewsService
    {
        private readonly IRepository<News> _newsRepository;

        public NewsService(IRepository<News> newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public async Task<IEnumerable<News>> GetAllNewsAsync()
        {
            return await _newsRepository.GetAllAsync();
        }

        public async Task<News> GetNewsByIdAsync(int id)
        {
            return await _newsRepository.GetByIdAsync(id);
        }

        public async Task AddNewsAsync(News news)
        {
            await _newsRepository.AddAsync(news);
        }

        public async Task UpdateNewsAsync(News news)
        {
            await _newsRepository.UpdateAsync(news);
        }

        public async Task DeleteNewsAsync(int id)
        {
            await _newsRepository.DeleteAsync(id);
        }
    }
}
