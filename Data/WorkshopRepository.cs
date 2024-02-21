using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Models;

namespace Workshop.Data
{
    public class WorkshopRepository : IWorkshopRepository
    {
        private readonly ApplicationDbContext context;
        public WorkshopRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<Order> CreateRepair(Order order)
        {
            context.Orders.Add(order);
            await context.SaveChangesAsync();
            return order;
        }
        public async Task DeleteRepair(Guid id)
        {
            var order = context.Orders.Find(id);
            context.Orders.Remove(order);
            await context.SaveChangesAsync();
        }
        public async Task<List<Order>> GetAllRepairs()
        {
            return await context.Orders.ToListAsync();
        }
        public async Task<Order> GetRepairById(Guid id)
        {
            return await context.Orders.FindAsync(id);
        }
        public async Task<Order> UpdateRepair(Order order)
        {
            var tmp = context.Orders.Find(order.Id);
            tmp = order;
            await context.SaveChangesAsync();
            return tmp;
        }
    }
}