﻿using APPLICATION.DOMAIN.ENTITY.COMPANY;
using APPLICATION.ENUMS;
using Microsoft.AspNetCore.Identity;

namespace APPLICATION.DOMAIN.ENTITY.ROLE;

public class Role : IdentityRole<Guid>
{
    /// <summary>
    /// Id da empresa vinculada a essa role.
    /// </summary>
    public Guid CompanyId { get; set; }

    /// <summary>
    /// Data de criação
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// Data de atualização
    /// </summary>
    public DateTime? Updated { get; set; }

    /// <summary>
    /// Usuário de cadastro.
    /// </summary>
    public Guid CreatedUserId { get; set; }

    /// <summary>
    /// Usuário que atualizou.
    /// </summary>
    public Guid? UpdatedUserId { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public Status Status { get; set; }

    #region Vinculos
    /// <summary>
    /// Vinculo com empresa.
    /// </summary>
    public virtual Company Company { get; set; }
    #endregion
}