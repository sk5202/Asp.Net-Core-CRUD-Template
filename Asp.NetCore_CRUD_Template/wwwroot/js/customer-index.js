(function ($) {
    function School() {
        var $this = this;

        function initilizeModel() {           
            $("#modal-action-customer").on('loaded.bs.modal', function (e) {               
                }).on('hidden.bs.modal', function (e) {                   
                    $(this).removeData('bs.modal');
                });            
        }       
        $this.init = function () {
            initilizeModel();
        }
    }
    $(function () {
        var self = new School();
        self.init();        
    })
}(jQuery))
