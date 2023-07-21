using Cord.SDK;
using Cord.SDK.Objects;
using Microsoft.AspNetCore.Mvc;

namespace Example;

[Route("[controller]")]
public sealed class ExampleCordController : ControllerBase
{
    private readonly ICord _cord;

    public ExampleCordController(ICord cord)
    {
        _cord = cord;
    }

    [HttpGet("Threads")]
    public async Task<IActionResult> GetThreads(CancellationToken cancellationToken)
    {
        return Ok(await _cord.Threads.V1.List(cancellationToken));
    }

    [HttpGet("Threads/{id}")]
    public async Task<IActionResult> GetThreads([FromRoute] string id, CancellationToken cancellationToken)
    {
        return Ok(await _cord.Threads.V1.Get(id, cancellationToken));
    }

    [HttpPut("Threads/{id}")]
    public async Task<IActionResult> GetThreads([FromRoute] string id, [FromBody] ThreadPutItem item,
        CancellationToken cancellationToken)
    {
        return Ok(await _cord.Threads.V1.Update(id, item, cancellationToken));
    }

    [HttpGet("Users")]
    public async Task<IActionResult> GetUsers([FromQuery] UserListFilter? filter, CancellationToken cancellationToken)
    {
        return Ok(await _cord.Users.V1.List(filter, cancellationToken));
    }

    [HttpPut("Organization/{id}")]
    public async Task<IActionResult> UpdateOrCreateOrganization([FromRoute] string id,
        [FromBody] OrganizationPutItem item,
        CancellationToken cancellationToken)
    {
        return Ok(await _cord.Organizations.V1.CreateOrUpdate(id, item, cancellationToken));
    }

    [HttpPut("Organization/{id}/UpdateMembers")]
    public async Task<IActionResult> UpdateOrganizationMembers([FromRoute] string id,
        [FromBody] OrganizationUpdateMembers members,
        CancellationToken cancellationToken)
    {
        return Ok(await _cord.Organizations.V1.UpdateMembers(id, members, cancellationToken));
    }

    [HttpPut("Organization/{id}/AddMembers")]
    public async Task<IActionResult> AddOrganizationMembers([FromRoute] string id, [FromBody] List<string> members,
        CancellationToken cancellationToken)
    {
        return Ok(await _cord.Organizations.V1.AddMembers(id, members, cancellationToken));
    }

    [HttpPut("Organization/{id}/RemoveMembers")]
    public async Task<IActionResult> RemoveOrganizationMembers([FromRoute] string id, [FromBody] List<string> members,
        CancellationToken cancellationToken)
    {
        return Ok(await _cord.Organizations.V1.RemoveMembers(id, members, cancellationToken));
    }

    [HttpGet("Organization")]
    public async Task<IActionResult> RemoveOrganizationMembers(CancellationToken cancellationToken)
    {
        return Ok(await _cord.Organizations.V1.List(cancellationToken));
    }

    [HttpGet("Organization/{id}")]
    public async Task<IActionResult> GetOrganization([FromRoute] string id, CancellationToken cancellationToken)
    {
        return Ok(await _cord.Organizations.V1.Get(id, cancellationToken));
    }
}