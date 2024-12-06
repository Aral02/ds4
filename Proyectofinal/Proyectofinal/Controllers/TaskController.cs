using System.Linq;
using System.Web.Http;
using Proyectofinal.Models;
using Proyectofinal.Data;
using System.Data.Entity;
using System.Net;

public class TasksController : ApiController
{
    private readonly TaskManagerContext db = new TaskManagerContext();

    // GET: api/Tasks
    public IHttpActionResult GetTasks()
    {
        return Ok(db.Tasks.ToList());
    }

    // GET: api/Tasks/5
    public IHttpActionResult GetTask(int id)
    {
        var task = db.Tasks.Find(id);
        if (task == null) return NotFound();
        return Ok(task);
    }

    // POST: api/Tasks
    public IHttpActionResult PostTask(Task task)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        db.Tasks.Add(task);
        db.SaveChanges();
        return CreatedAtRoute("DefaultApi", new { id = task.TaskId }, task);
    }

    // PUT: api/Tasks/5
    public IHttpActionResult PutTask(int id, Task task)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        if (id != task.TaskId) return BadRequest();

        db.Entry(task).State = EntityState.Modified;
        db.SaveChanges();
        return StatusCode(HttpStatusCode.NoContent);
    }

    // DELETE: api/Tasks/5
    public IHttpActionResult DeleteTask(int id)
    {
        var task = db.Tasks.Find(id);
        if (task == null) return NotFound();

        db.Tasks.Remove(task);
        db.SaveChanges();
        return Ok(task);
    }
}

