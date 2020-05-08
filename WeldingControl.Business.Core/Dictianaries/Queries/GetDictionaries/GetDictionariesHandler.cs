using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using WeldingControl.Data.Infrastructure;

namespace WeldingControl.Business.Core.Dictionaries.Queries.GetDictionaries
{
    public class GetDictionariesHandler : IRequestHandler<GetDictionariesQuery, DictionariesDto>
    {
        private readonly DomainContext _context;
        public GetDictionariesHandler(DomainContext context)
        {
            _context = context;
        }

        public async Task<DictionariesDto> Handle(GetDictionariesQuery request, CancellationToken cancellationToken)
        {
            var additionalMaterials = await _context.AdditionalMaterials
                .Select(x => new AdditionalMaterialDto
                {
                    Id = x.Id,
                    Description = x.Description,
                    Abbreviation = x.Abbreviation,
                    
                })
                .ToListAsync(cancellationToken); 

            var connectionforms = await _context.ConnectionForms
               .Select(x => new ConnectionFormDto
               {
                   Id = x.Id,
                   Description = x.Description,
                   Abbreviation = x.Abbreviation,

               })
               .ToListAsync(cancellationToken);

            var fillerMaterial = await _context.FillerMaterials
               .Select(x => new FillerMaterialDto
               {
                   Id = x.Id,
                   Description = x.Description,
                   Abbreviation = x.Abbreviation,

               })
               .ToListAsync(cancellationToken);

            var mainMaterial = await _context.MainMaterials
               .Select(x => new MainMaterialDto
               {
                   Id = x.Id,
                   Description = x.Description,
                   Group = x.Group,
                   SubGroup = x.SubGroup,

               })
               .ToListAsync(cancellationToken);

            var organization = await _context.Organizations
               .Select(x => new OrganizationDto
               {
                   Id = x.Id,
                   Name =x.Name,

               })
               .ToListAsync(cancellationToken);

            var shieldingGas = await _context.ShieldingGases
               .Select(x => new ShieldingGasDto
               {
                   Id = x.Id,
                   Description = x.Description,
                   Abbreviation = x.Abbreviation,

               })
               .ToListAsync(cancellationToken);

            var weldingMaterial = await _context.WeldingMaterials
               .Select(x => new WeldingMaterialDto
               {
                   Id = x.Id,
                   Description = x.Description,
                   Abbreviation = x.Abbreviation,

               })
               .ToListAsync(cancellationToken);

            var weldingPosition = await _context.WeldingPositions
               .Select(x => new WeldingPositionDto
               {
                   Id = x.Id,
                   Description = x.Description,
                   Abbreviation = x.Abbreviation, 
                   Code = x.Code,

               })
               .ToListAsync(cancellationToken);

            var weldingProcess = await _context.WeldingProcesses
               .Select(x => new WeldingProcessDto
               {
                   Id = x.Id,
                   Description = x.Description,
                   Abbreviation = x.Abbreviation,
                   Code = x.Code,

               })
               .ToListAsync(cancellationToken);

            var weldingTechnique = await _context.WeldingTechniques
               .Select(x => new WeldingTechniqueDto
               {
                   Id = x.Id,
                   Description = x.Description,
                   Abbreviation = x.Abbreviation,

               })
               .ToListAsync(cancellationToken);

            var weldType = await _context.WeldTypes
               .Select(x => new WeldTypeDto
               {
                   Id = x.Id,
                   Description = x.Description,
                   Abbreviation = x.Abbreviation,

               })
               .ToListAsync(cancellationToken);

            return new DictionariesDto 
            {
                AdditionalMaterials = additionalMaterials, 
                ConnectionForms = connectionforms, 
                FillerMaterials  = fillerMaterial,
                MainMaterials = mainMaterial,
                Organizations = organization,
                ShieldingGas = shieldingGas,
                WeldingMaterials = weldingMaterial,
                WeldingPositions = weldingPosition,
                WeldingProcesses = weldingProcess,
                WeldingTechniques = weldingTechnique,
                WeldTypes = weldType,
            };

        }
    }
}
