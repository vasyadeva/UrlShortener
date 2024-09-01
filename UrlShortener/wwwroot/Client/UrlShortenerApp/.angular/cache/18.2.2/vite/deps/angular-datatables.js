import {
  CommonModule
} from "./chunk-IJXGLLET.js";
import {
  Directive,
  ElementRef,
  Input,
  NgModule,
  Renderer2,
  ViewContainerRef,
  setClassMetadata,
  ɵɵdefineDirective,
  ɵɵdefineInjector,
  ɵɵdefineNgModule,
  ɵɵdirectiveInject
} from "./chunk-NZ3K4W5G.js";
import "./chunk-2CVCC5YH.js";

// node_modules/angular-datatables/fesm2022/angular-datatables.mjs
var _DataTableDirective = class _DataTableDirective {
  constructor(el, vcr, renderer) {
    this.el = el;
    this.vcr = vcr;
    this.renderer = renderer;
    this.dtOptions = {};
  }
  ngOnInit() {
    if (this.dtTrigger) {
      this.dtTrigger.subscribe((options) => {
        this.displayTable(options);
      });
    } else {
      this.displayTable(null);
    }
  }
  ngOnDestroy() {
    if (this.dtTrigger) {
      this.dtTrigger.unsubscribe();
    }
    if (this.dt) {
      this.dt.destroy(true);
    }
  }
  displayTable(dtOptions) {
    if (dtOptions) {
      this.dtOptions = dtOptions;
    }
    this.dtInstance = new Promise((resolve, reject) => {
      Promise.resolve(this.dtOptions).then((resolvedDTOptions) => {
        const isTableEmpty = Object.keys(resolvedDTOptions).length === 0 && $("tbody tr", this.el.nativeElement).length === 0;
        if (isTableEmpty) {
          reject("Both the table and dtOptions cannot be empty");
          return;
        }
        if (resolvedDTOptions.columns) {
          resolvedDTOptions.columns.forEach((col) => {
            if ((col.id ?? "").trim() === "") {
              col.id = this.getColumnUniqueId();
            }
          });
        }
        setTimeout(() => {
          let options = {
            rowCallback: (row, data, index) => {
              if (resolvedDTOptions.columns) {
                const columns = resolvedDTOptions.columns;
                this.applyNgPipeTransform(row, columns);
                this.applyNgRefTemplate(row, columns, data);
              }
              if (resolvedDTOptions.rowCallback) {
                resolvedDTOptions.rowCallback(row, data, index);
              }
            }
          };
          options = Object.assign({}, resolvedDTOptions, options);
          this.dt = $(this.el.nativeElement).DataTable(options);
          resolve(this.dt);
        });
      });
    });
  }
  applyNgPipeTransform(row, columns) {
    const colsWithPipe = columns.filter((x) => x.ngPipeInstance && !x.ngTemplateRef);
    colsWithPipe.forEach((el) => {
      const pipe = el.ngPipeInstance;
      const pipeArgs = el.ngPipeArgs || [];
      const i = columns.filter((c) => c.visible !== false).findIndex((e) => e.id === el.id);
      const rowFromCol = row.childNodes.item(i);
      const rowVal = $(rowFromCol).text();
      const rowValAfter = pipe.transform(rowVal, ...pipeArgs);
      $(rowFromCol).text(rowValAfter);
    });
  }
  applyNgRefTemplate(row, columns, data) {
    const colsWithTemplate = columns.filter((x) => x.ngTemplateRef && !x.ngPipeInstance);
    colsWithTemplate.forEach((el) => {
      const {
        ref,
        context
      } = el.ngTemplateRef;
      const i = columns.filter((c) => c.visible !== false).findIndex((e) => e.id === el.id);
      const cellFromIndex = row.childNodes.item(i);
      $(cellFromIndex).html("");
      const _context = Object.assign({}, context, context?.userData, {
        adtData: data
      });
      const instance = this.vcr.createEmbeddedView(ref, _context);
      this.renderer.appendChild(cellFromIndex, instance.rootNodes[0]);
    });
  }
  getColumnUniqueId() {
    let result = "";
    const characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    for (let i = 0; i < 6; i++) {
      const randomIndex = Math.floor(Math.random() * characters.length);
      result += characters.charAt(randomIndex);
    }
    return result.trim();
  }
};
_DataTableDirective.ɵfac = function DataTableDirective_Factory(__ngFactoryType__) {
  return new (__ngFactoryType__ || _DataTableDirective)(ɵɵdirectiveInject(ElementRef), ɵɵdirectiveInject(ViewContainerRef), ɵɵdirectiveInject(Renderer2));
};
_DataTableDirective.ɵdir = ɵɵdefineDirective({
  type: _DataTableDirective,
  selectors: [["", "datatable", ""]],
  inputs: {
    dtOptions: "dtOptions",
    dtTrigger: "dtTrigger"
  }
});
var DataTableDirective = _DataTableDirective;
(() => {
  (typeof ngDevMode === "undefined" || ngDevMode) && setClassMetadata(DataTableDirective, [{
    type: Directive,
    args: [{
      selector: "[datatable]"
    }]
  }], () => [{
    type: ElementRef
  }, {
    type: ViewContainerRef
  }, {
    type: Renderer2
  }], {
    dtOptions: [{
      type: Input
    }],
    dtTrigger: [{
      type: Input
    }]
  });
})();
var _DataTablesModule = class _DataTablesModule {
};
_DataTablesModule.ɵfac = function DataTablesModule_Factory(__ngFactoryType__) {
  return new (__ngFactoryType__ || _DataTablesModule)();
};
_DataTablesModule.ɵmod = ɵɵdefineNgModule({
  type: _DataTablesModule,
  declarations: [DataTableDirective],
  imports: [CommonModule],
  exports: [DataTableDirective]
});
_DataTablesModule.ɵinj = ɵɵdefineInjector({
  imports: [CommonModule]
});
var DataTablesModule = _DataTablesModule;
(() => {
  (typeof ngDevMode === "undefined" || ngDevMode) && setClassMetadata(DataTablesModule, [{
    type: NgModule,
    args: [{
      imports: [CommonModule],
      declarations: [DataTableDirective],
      exports: [DataTableDirective]
    }]
  }], null, null);
})();
export {
  DataTableDirective,
  DataTablesModule
};
/*! Bundled license information:

angular-datatables/fesm2022/angular-datatables.mjs:
  (**
   * @license
   *
   * Use of this source code is governed by an MIT-style license that can be
   * found in the LICENSE file at https://raw.githubusercontent.com/l-lin/angular-datatables/master/LICENSE
   *)
*/
//# sourceMappingURL=angular-datatables.js.map
