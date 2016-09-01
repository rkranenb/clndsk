using System;

namespace clndsk {

    public interface ICleaner {
        void Clean();
    }

    public class Cleaner : ICleaner {

        public void Clean() {
            throw new NotImplementedException();
        }

    }
}
